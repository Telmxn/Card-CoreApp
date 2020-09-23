using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CardApp.Models;

namespace CardApp.Controllers
{
    public class CardsController : Controller
    {
        private readonly CardDbContext _context;

        public CardsController(CardDbContext context)
        {
            _context = context;
        }

        // GET: Cards
        public ActionResult Index()
        {
            var cards = _context.Cards.ToList();
            return View(cards);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        public async Task<ActionResult> Add(Card card)
        {
            if (card.Id == 0)
            {
                _context.Cards.Add(card);
            }
            else
            {
                var updatedCard = _context.Cards.Find(card.Id);
                if (updatedCard == null)
                {
                    //return ();
                }
                updatedCard.CardHolder = card.CardHolder;
                updatedCard.CardNumber = card.CardNumber;
                updatedCard.ExpDate = card.ExpDate;
                updatedCard.Balance = card.Balance;
                updatedCard.CVC = card.CVC;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Cards");
        }
        public ActionResult Update(int id)
        {
            var card = _context.Cards.Find(id);
            if (card == null)
            {
                //return HttpNotFound();
            }
            return View("Add", card);
        }
        public ActionResult Delete(int Id)
        {
            Card card = _context.Cards.Where(x => x.Id == Id).SingleOrDefault();
            if (card != null)
            {
                _context.Cards.Remove(card);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Cards");
        }
        private bool CardExists(int id)
        {
            return _context.Cards.Any(e => e.Id == id);
        }
    }
}
