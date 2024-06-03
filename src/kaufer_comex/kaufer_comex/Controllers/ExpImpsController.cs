﻿using kaufer_comex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kaufer_comex.Controllers
{
    public class ExpImpsController : Controller
    {
        private readonly AppDbContext _context;

        public ExpImpsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var dados = await _context.ExpImps
                    .OrderBy(e => e.Nome)
                    .ToListAsync();

                return View(dados);
            }
            catch
            {
				TempData["MensagemErro"] = $"Erro ao carregar os dados. Tente novamente";
				return View();
			}
        }
        public IActionResult Create()
        {
            try
            {
                return View();
            }
            catch
            {
				TempData["MensagemErro"] = $"Ocorreu um erro inesperado. Por favor, tente novamente.";
				return View();

			}
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ExpImp expimp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.ExpImps.Add(expimp);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                return View(expimp);
            }
            catch {
				TempData["MensagemErro"] = $"Ocorreu um erro inesperado. Por favor, tente novamente.";
				return View();

			}
		}

        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id == null)
                    return NotFound();

                var dados = await _context.ExpImps.FindAsync(id);
                if (dados == null)
                    return NotFound();

                return View(dados);
            }
            catch
            {
				TempData["MensagemErro"] = $"Ocorreu um erro inesperado. Por favor, tente novamente.";
				return View();

			}

		}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ExpImp expimp)
        {
            try
            {
                if (id != expimp.Id)
                    return NotFound();

                if (ModelState.IsValid)
                {
                    _context.ExpImps.Update(expimp);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                if (id == null)
                    return NotFound();

                var dados = await _context.ExpImps.FindAsync(id);

                if (id == null)
                    return NotFound();

                return View(dados);
            }
            catch
            {
				TempData["MensagemErro"] = $"Ocorreu um erro inesperado. Por favor, tente novamente.";
				return View();

			}
		}


        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (id == null)
                    return NotFound();

                var dados = await _context.ExpImps.FindAsync(id);

                if (id == null)
                    return NotFound();

                return View(dados);
            }
            catch {
				TempData["MensagemErro"] = $"Ocorreu um erro inesperado. Por favor, tente novamente.";
				return View();
			}
		}

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            try
            {
                if (id == null)
                    return NotFound();

                var dados = await _context.ExpImps.FindAsync(id);

                if (id == null)
                    return NotFound();

                _context.ExpImps.Remove(dados);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch
            {
				TempData["MensagemErro"] = $"Ocorreu um erro inesperado. Por favor, tente novamente.";
				return View();

			}
		}
    }
}
