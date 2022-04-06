using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{/*
    class Program1
    {
        
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");


            //WhereWithContains();
            //StudentOperations();
            //OfTypeSample();
            //OrderBySample();
            //ThenBySample();
            //GroupBySample();
            //JoinsSample();
            //GroupJoinsSample();
            //SelectSample();
            //IntersectSample();
            // UnionSample();
            //RightLeftJoinSample();
            //AggregateMethodsSample();

            Console.ReadKey();
        }

        static void WhereWithContains()
        {
            // Data source
            string[] names = { "Bill", "Steve", "James", "Debbie", "Maria" };

            // LINQ Query 
            //var myLinqQuery = from name in names
            //                  where name.Contains('a')
            //                  select name;

            var myLinqQuery = names.Where(s => s.Contains("a"));

            // Query execution
            foreach (var name in myLinqQuery)
                Console.WriteLine(name + " ");

            Student[] studentArray = { null,
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
                    new Student() { StudentID = 7, StudentName = "Rob",Age = 19  } ,
                };

            List<string> listofData = new List<string> ();

            var output = listofData.FirstOrDefault();
            
            //foreach (var student in output)
            //    Console.WriteLine(student.StudentName);
        }

        static void StudentOperations()
        {
            Student[] studentArray = {
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
                    new Student() { StudentID = 7, StudentName = "Rob",Age = 19  } ,
                };

            // Use LINQ to find teenager students
            Student[] teenAgerStudents = studentArray.Where(s => s.Age > 18 && s.Age < 26).ToArray();
            foreach (var student in teenAgerStudents)
                Console.WriteLine(student.StudentID + " => " + student.StudentName + " => " + student.Age.ToString());

            Console.WriteLine("=============");
            // Use LINQ to find first student whose name is Bill 
            Student ram = studentArray.Where(s => s.StudentName == "Ram").FirstOrDefault();
            Console.WriteLine(ram.StudentID + " => " + ram.StudentName + " => " + ram.Age.ToString());

            Console.WriteLine("=============");
            // Use LINQ to find student whose StudentID is 5

            Student student3 = studentArray.Where(s => s.StudentID == 3).FirstOrDefault();
            Console.WriteLine(student3.StudentID + " => " + student3.StudentName + " => " + student3.Age.ToString());

            Console.WriteLine("=============");
        }

        static void OfTypeSample()
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            // string type
            //var stringResult = from x in mixedList.OfType<string>()
            //                   select x;

            //foreach (var item in mixedList)
            //{
            //    Console.WriteLine(item);
            //}

            // student type
            //var studentResult = from s in mixedList.OfType<Student>()
            //                    select s;

            //foreach (var item in studentResult)
            //{
            //    Console.WriteLine(item.StudentName);
            //}

            // int type
            var intResult = from y in mixedList.OfType<int>()
                            select y;

            foreach (var item in intResult)
            {
                Console.WriteLine(item);
            }
        }

        private static void OrderBySample()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            //var orderByResult = from s in studentList
            //                    orderby s.StudentName
            //                    select s;
            // OR
            var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

            //=============================================================

            //var orderByDescendingResult = from s in studentList
            //                              orderby s.StudentName descending
            //                              select s;
            //OR
            var orderByDescendingResult = studentList.OrderByDescending(s => s.StudentName);
        }

        private static void ThenBySample()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
            };
            var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

            var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
        }

        private static void GroupBySample()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
            };

            //var groupedResult = from s in studentList
            //                    group s by s.Age;

            // var groupedResult = studentList.GroupBy(s => s.Age);

            var groupedResult = studentList.ToLookup(s => s.Age);

            //iterate each group        
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

                foreach (Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
        }

        private static void JoinsSample()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
                new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
                new Student() { StudentID = 5, StudentName = "Ron"  }
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="1st Standard"},
                new Standard(){ StandardID = 2, StandardName="2nd Standard"},
                new Standard(){ StandardID = 3, StandardName="3rd Standard"}
            };

            var innerJoin = studentList.Join(// outer sequence 
                                  standardList,  // inner sequence 
                                  student => student.StandardID,    // outerKeySelector
                                  standard => standard.StandardID,  // innerKeySelector
                                  (student, standard) => new  // result selector
                                  {
                                      StudentName = student.StudentName,
                                      StandardName = standard.StandardName
                                  });

            //var innerJoin = from s in studentList // outer sequence
            //                join st in standardList //inner sequence 
            //                on s.StandardID equals st.StandardID // key selector 
            //                select new
            //                { // result selector 
            //                    StudentName = s.StudentName,
            //                    StandardName = st.StandardName
            //                };

            foreach (var item in innerJoin)
            {
                Console.WriteLine(item.StudentName + " => " + item.StandardName);
            }
        }

        private static void GroupJoinsSample()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
                new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram",  StandardID =2 },
                new Student() { StudentID = 5, StudentName = "Ron", StandardID =3 }
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
                                            std => std.StandardID, //outerKeySelector 
                                            s => s.StandardID,     //innerKeySelector
                                            (std, studentsGroup) => new // resultSelector 
                                            {
                                                Students = studentsGroup,
                                                StandarFulldName = std.StandardName
                                            });

            //var groupJoin = from std in standardList
            //                join s in studentList
            //                on std.StandardID equals s.StandardID
            //                into studentGroup
            //                select new
            //                {
            //                    Students = studentGroup,
            //                    StandardName = std.StandardName
            //                };


            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.StandarFulldName);

                foreach (var stud in item.Students)
                    Console.WriteLine(stud.StudentName);
            }
        }

        private static void SelectSample()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John" },
                new Student() { StudentID = 2, StudentName = "Moin" },
                new Student() { StudentID = 3, StudentName = "Bill" },
                new Student() { StudentID = 4, StudentName = "Ram" },
                new Student() { StudentID = 5, StudentName = "Ron" }
            };

            //var selectResult = from s in studentList
            //                   select s.StudentName;

            //var selectResult = from s in studentList
            //                   select new { Name = "Mr. " + s.StudentName, Age = s.Age };

            var selectResult = studentList.Select(s => new
            {
                Name = s.StudentName,
                Age = s.Age
            });
        }

        private static void IntersectSample()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            var result = strList1.Intersect(strList2); // Four, Five

            foreach (string str in result)
                Console.WriteLine(str);

            // OR

            IList<Student> studentList1 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            IList<Student> studentList2 = new List<Student>() {
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 22 }
            };

            var resultedCol = studentList1.Intersect(studentList2, new StudentComparer());

            foreach (Student std in resultedCol)
                Console.WriteLine(std.StudentName);
        }

        private static void UnionSample()
        {
            //IList<string> strList1 = new List<string>() { "One", "Two", "three", "Four" };
            //IList<string> strList2 = new List<string>() { "Two", "three", "Four", "Five" };

            //var result = strList1.Union(strList2); //

            //foreach (string str in result)
            //    Console.WriteLine(str);

            // OR

            IList<Student> studentList1 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            IList<Student> studentList2 = new List<Student>() {
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var resultedCol = studentList1.Union(studentList2, new StudentComparer());

            foreach (Student std in resultedCol)
                Console.WriteLine(std.StudentID + "," + std.StudentName + "," + std.Age);
        }

        private static void RightLeftJoinSample()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
                new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
                new Student() { StudentID = 5, StudentName = "Ron"  }
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="1st Standard"},
                new Standard(){ StandardID = 2, StandardName="2nd Standard"},
                new Standard(){ StandardID = 3, StandardName="3rd Standard"}
            };

            var leftJoin = from st in standardList join s in studentList //inner sequence 
                            on st.StandardID equals s.StandardID into temp from t in temp.DefaultIfEmpty()
                            select new
                            { // result selector 
                                st.StandardID,
                                t?.StudentName
                            };

            foreach (var item in leftJoin)
            {
                Console.WriteLine(item.StandardID +","+ item.StudentName);
            }
        }

        private static void AggregateMethodsSample()
        {
            // SUM, Average, Count, Min and Max
            List<int> list = new List<int> { 1, 4, 7, 9, 10 };

            var count = list.Count();
            var avg = list.Average();
            var sum = list.Sum();
            var min = list.Min();
            var max = list.Max();

            IList<Student> studentList1 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var sumOfAge = studentList1.Sum(s => s.Age);
            var avgAge = studentList1.Average(s => s.Age);
        }

    }

    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }

    class Standard
    {
        public int StandardID { get; set; }
        public String StandardName { get; set; }
    }

    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID &&
                            x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
        */
}
