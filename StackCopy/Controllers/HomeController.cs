using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StackCopy.Models;

namespace StackCopy.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // public class Stack : ICloneable, System.Collections.ICollection
            // public class Queue : ICloneable, System.Collections.ICollection


            return View();
        }
        public void StackOriginal() {
            Stack<int> originalStack = new Stack<int>(3);
            Stack<int> Stackcopy = new Stack<int>(3);
            Queue<int> QueueTemp = new Queue<int>(3);
            for(int i = 1; i<4; i++ ) {originalStack.Push(i);}

            while (originalStack.Count >0)  // there is no IsEmpty()
            {
                Stackcopy.Push(originalStack.Pop());
            }
            while (Stackcopy.Count >0)  // there is no IsEmpty()
            {
                QueueTemp.Enqueue(Stackcopy.Pop());
            }
            while (QueueTemp.Count>0) 
            {
                originalStack.Push(QueueTemp.Peek());
                Stackcopy.Push(QueueTemp.Dequeue());
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
