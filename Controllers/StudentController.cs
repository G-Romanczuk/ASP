using System;
using System.Collections.Generic;

using EPaczucha.Models;
using sStudent = EPaczucha.Models.Student;

using Microsoft.AspNetCore.Mvc;


namespace EPaczucha.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository repository)
        {
            _studentRepository = repository;
        }

        public ViewResult Index()
        {
            return View(_studentRepository.Students);
        }

        private static readonly List<sStudent> _students = new()
        {
            new sStudent() {Id = 1, FirstName = "Dawid", LastName = "Nowak", BirthDate = Convert.ToDateTime("2000-03-21")},
            new sStudent() {Id = 2, FirstName = "Kacper", LastName = "Sroka", BirthDate = Convert.ToDateTime("2003-06-18")},
            new sStudent() {Id = 3, FirstName = "Kuba", LastName = "Kowalski", BirthDate = Convert.ToDateTime("1998-12-01")},
        };

        private static int _amountOfStudents = _students.Count;

        //public IActionResult Index() => View("List", _students);

        public IActionResult List() => View(_students);

        public IActionResult Add() => View("Add");

        [HttpPost]
        public IActionResult Add(sStudent student)
        {
            if (ModelState.IsValid)
            {
                student.Id = ++_amountOfStudents;
                _students.Add(student);

                return View("List", _students);
            }
            else return View("Add");
        }


        public IActionResult Edit(int id)
        {
            var student = _students.Find(x => x.Id == id);

            return View("Edit", student);
        }

        public IActionResult EditDone(sStudent student)
        {
            _students.Find(x => x.Id == student.Id).FirstName = student.FirstName;
            _students.Find(x => x.Id == student.Id).LastName = student.LastName;
            _students.Find(x => x.Id == student.Id).BirthDate = student.BirthDate;

            return View("List", _students);
        }

        public IActionResult Delete(int id)
        {
            _students.Remove(_students.Find(x => x.Id == id));

            return View("List", _students);
        }

        public IActionResult Details(int id)
        {
            var student = _students.Find(x => x.Id==id);

            ViewBag.FirstName = student.FirstName;
            ViewBag.LastName = student.LastName;
            ViewBag.BirthDate = student.BirthDate;
            ViewBag.StudentIndex = student.StudentIndex;

            return View(student);
        }
    }
}
