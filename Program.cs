using System;
using System.Security.AccessControl;
using System.Security.Cryptography;

namespace myProject
{
    class YarnProject
    {
        private int _Id;
        private string _ProjectType;
        private string _Fiber;
        private int _Hours;

        public YarnProject()
        {
            _Id = 0;
            _ProjectType = "";
            _Fiber = "";
            _Hours = 0;
        }
        public YarnProject(int id, string type, string fiber, int hours)
        {
            _Id = id;
            _ProjectType = type;
            _Fiber = fiber;
            _Hours = hours;
        }

        public int GetId()
        {
            return _Id;
        }
        public void SetId(int i)
        {
            _Id = i;
        }
        public string GetProjectType()
        {
            return _ProjectType;
        }
        public void SetProjectType(string t)
        {
            _ProjectType = t;
        }

        public string GetFiber()
        {
            return _Fiber;
        }
        public void SetFiber(string f)
        {
            _Fiber = f;
        }
        public int GetHours()
        {
            return _Hours;
        }
        public void SetHours(int h)
        {
            _Hours = h;
        }
    }
    class myProjects
    {
        static void Main(string[] args)
        {
            YarnProject project1 = new YarnProject();
            project1.SetId(1);
            project1.SetProjectType("Blanket");
            project1.SetFiber("Acrylic");
            project1.SetHours(40);

            YarnProject project2 = new YarnProject();
            project2.SetId(2);
            project2.SetProjectType("Baby Toy");
            project2.SetFiber("Cotton");
            project2.SetHours(10);

            YarnProject project3 = new YarnProject(3, "Scarf", "Merino Wool", 5);
            
            YarnProject project4 = new YarnProject(4, "Cat bed", "Chenille/Polyester", 2);


            displayProjects(project1);
            displayProjects(project2);
            displayProjects(project3);
            displayProjects(project4);
        }

        static void displayProjects(YarnProject yarn)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Please see yarn project details below: \n");
            Console.WriteLine($"Project ID: {yarn.GetId()}");
            Console.WriteLine($"Project Type: {yarn.GetProjectType()}");
            Console.WriteLine($"Fiber Used: {yarn.GetFiber()}");
            Console.WriteLine($"Hours to make: {yarn.GetHours()}");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
        }


    }
}

