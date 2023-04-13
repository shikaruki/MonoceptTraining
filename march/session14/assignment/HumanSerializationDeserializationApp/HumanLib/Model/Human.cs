using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanSerializationApp.Model
{
    [Serializable]
    public class Human
    {
        private string _name;
        private int _age;
        private float _weight;
        private float _height;

        public Human(string name, int age, float weight, float height)
        {
            _name = name;
            _age = age;
            _weight = weight;
            _height = height;
        }

        public void Workout()
        {
            _weight -= (float)(_weight * 0.05);

        }
        public void Eat()
        {
            _height += (float)(_height * 0.02);
            _weight += (float)(_weight * 0.1);
        }

        public string Name { get { return _name;} }
        public int Age { get { return _age;} }
        public float Weight { get { return _weight;} }
        public float Height { get { return _height;} }
    }
}
