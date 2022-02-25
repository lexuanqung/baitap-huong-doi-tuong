using System;
using System.Collections.Generic;
using System.Text;

namespace bai_seach3
{
    public class Person
    {
        private string code, name;
        private int age;
        public Person() { }
        public Person(string c , string n, int a)
        {
            code = c;
            name = n;
            age = a > 0 ? a : 0;
        }
        public void setCode(string Newcode) { this.code = Newcode; }
        public void setName(String Newname) { this.name = Newname; }
        public void setAge(int Newage) { this.age = Newage; }
        public string getCode() { return code; }
        public string getName() { return name; }
        public int getAge() { return age; }
        public void input()
        {
            Console.Write("Nhap code: ");
            code = Console.ReadLine();
            Console.Write("Nhap name: ");
            name = Console.ReadLine();
            Console.Write("Nhap age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
        public string toString()
        {
            return code + ", " + name + ", " + age;
        }
    }
    
}
