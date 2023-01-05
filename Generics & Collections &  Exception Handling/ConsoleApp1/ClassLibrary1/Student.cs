using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class Student<T, U>
    {
        private U name;
        private T age;
        private List<U> subject;
        private dynamic minAge = 18;
        private Regex regex;

        public Student()
        {
            subject = new List<U>();
        }
        public void addSubject(in U Subject)
        {
            subject.Add(Subject);
        }
        public void setAge(in T age)
        {
            dynamic d1 = age;
            if (d1 >= minAge)
            {
                this.age = age;
            }
            else
            {
                throw new myException("Age must be 18 or 18+");
            }
        }
        public void setName(in U name)
        {
            dynamic d2 = name;
            regex = new Regex("^[a-zA-Z]+$");
            if (regex.IsMatch(d2))
            {
                this.name = name;
            }
            else
            {
                throw new myException("Name doesn't contain any number or special character");
            }
        }
        public U getName
        {
            get { return this.name; }
        }

        public T getAge
        {
            get { return this.age; }
        }

        public List<U> getSubject()
        {
            return subject;
        }
    }
}