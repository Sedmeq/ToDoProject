using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersApp.Data;
using UsersApp.Models;

namespace UsersApp.Controllers
{
    [Authorize]
    public class TodoController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<Users> _userManager;

        public TodoController(AppDbContext context, UserManager<Users> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var todos = await _context.ToDos
                .Where(t => t.UserId == userId)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            return View(todos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return Json(new { success = false, message = "Title is required" });
            }

            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                return Json(new { success = false, message = "User not found" });
            }

            var todo = new ToDo
            {
                Title = title.Trim(),
                UserId = userId,
                IsCompleted = false
            };

            _context.ToDos.Add(todo);
            await _context.SaveChangesAsync();

            return Json(new { success = true, todo = new { todo.Id, todo.Title, todo.IsCompleted } });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Toggle(int id)
        {
            var userId = _userManager.GetUserId(User);
            var todo = await _context.ToDos
                .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId);

            if (todo == null)
            {
                return Json(new { success = false, message = "Todo not found" });
            }

            todo.IsCompleted = !todo.IsCompleted;
            await _context.SaveChangesAsync();

            return Json(new { success = true, isCompleted = todo.IsCompleted });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var userId = _userManager.GetUserId(User);
            var todo = await _context.ToDos
                .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId);

            if (todo == null)
            {
                return Json(new { success = false, message = "Todo not found" });
            }

            _context.ToDos.Remove(todo);
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }

        [HttpGet]
        public async Task<IActionResult> GetTodos(string filter = "all")
        {
            var userId = _userManager.GetUserId(User);
            var query = _context.ToDos.Where(t => t.UserId == userId);

            switch (filter.ToLower())
            {
                case "active":
                    query = query.Where(t => !t.IsCompleted);
                    break;
                case "completed":
                    query = query.Where(t => t.IsCompleted);
                    break;
            }

            var todos = await query.OrderByDescending(t => t.CreatedAt).ToListAsync();

            return Json(new { success = true, todos = todos.Select(t => new { t.Id, t.Title, t.IsCompleted }) });
        }
    }
}