using StudentsApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using StudentsApp.Constants;
using StudentsApp.ViewModels;

namespace StudentsApp.Repository
{
    public class XmlStudentsRepository: StudentsRepository
    {
        private readonly XDocument _doc;
        private readonly string _fileName;
        
        public XmlStudentsRepository(string fileName)
        {
            try
            {
                _fileName = fileName;
                _doc = XDocument.Load(fileName);
            }
            catch (FileNotFoundException e)
            {
                var errorView = new ErrorView(ApplicationCommands.Close, "Repository file is not found.");
                ShowModel(errorView);
            }
            catch (Exception e)
            {
                var errorView = new ErrorView(new ErrorViewModel(o => Application.Current.Shutdown()) { ErrorText = e.Message });
                ShowModel(errorView);
            }
        }

        public override IList<IStudent> GetStudents()
        {
            var result = new List<IStudent>();

            if (_doc?.Root != null)
            {
                var students = _doc.Root.Elements();
                foreach (var student in students)
                {
                    int id;
                    var _id = student.Attribute(Constant.Id).Value ?? "Unknown";
                    id = Convert.ToInt32(_id);
                    var lname = student.Elements(Constant.LastName).FirstOrDefault()?.Value ?? "Unknown";
                    var fname = student.Elements(Constant.FirstName).FirstOrDefault()?.Value ?? "Unknown";
                    var ageStr = student.Elements(Constant.Age).FirstOrDefault()?.Value ?? "Unknown";
                    int age;
                    if (!int.TryParse(ageStr, out age))
                    {
                        age = 20;
                    }
                    var genderStr = student.Elements(Constant.Gender).FirstOrDefault()?.Value ?? "Unknown";
                    int gender;
                    if(!int.TryParse(genderStr, out gender))
                    {
                        gender = 1;
                    }
                    string _gender;
                    if (gender == 0)
                    {
                        _gender = "Муж";
                    }
                    else { _gender = "Жен"; }
                    result.Add(new Student(id,lname,fname, age, _gender));
                }
            }
            return result;
        }

        public override void AddStudent(IStudent student)
        {
            var newStudentElement = new XElement(Constant.StudentElementName);
            newStudentElement.Add(new XAttribute(Constant.Id, student.Id));
            newStudentElement.Add(new XElement(Constant.FirstName, student.FirstName));
            newStudentElement.Add(new XElement(Constant.LastName, student.LastName));
            newStudentElement.Add(new XElement(Constant.Age, student.Age));
            if (student.Gender == "Муж")
            {
                newStudentElement.Add(new XElement(Constant.Gender, 0));
            }
            else
            {
                newStudentElement.Add(new XElement(Constant.Gender, 1));
            }

            _doc.Root?.Add(newStudentElement);
            _doc.Save(_fileName);
        }

        public override void UpdateStudent(IStudent student)
        {
            XElement xroot = _doc.Root;
            foreach (XElement xr in xroot.Elements(Constant.StudentElementName))
            {
                string id = xr.Attribute(Constant.Id).Value;
                if (id == student.Id.ToString())
                {
                    xr.Attribute(Constant.Id).Value = student.Id.ToString();
                    xr.Element(Constant.FirstName).Value = student.FirstName;
                    xr.Element(Constant.LastName).Value = student.LastName;
                    xr.Element(Constant.Age).Value = student.Age.ToString();
                    if(student.Gender == "Муж")
                    {
                        xr.Element(Constant.Gender).Value = String.Format("0");
                    }
                    else { xr.Element(Constant.Gender).Value = String.Format("1"); }
                    break;
                }
            }
            _doc.Save(_fileName);
        }

        public override void DeleteStudent(IStudent student)
        {
            XElement xroot = _doc.Root;
            foreach(XElement xr in xroot.Elements(Constant.StudentElementName))
            {
                string id = xr.Attribute(Constant.Id).Value;
                if(id == student.Id.ToString())
                {
                    xr.Remove();
                    break;
                }
            }
            _doc.Save(_fileName);
        }

        private void ShowModel(Window window)
        {
            window.ShowDialog();
        }
    }
}
