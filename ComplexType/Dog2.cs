using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexType
{
    public class Trainer
    {
        void Operate()
        {
            var dog = new Poodle();
            dog.HasSpoken += dog_HasSpoken;
        }

        void dog_HasSpoken(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    public partial class Dog
    {

        /****ENCAPSULATION****/

        //properties hold values
        private string _name;
        public string Name
        {
            get { return _name; }

            //look at value
            //the scrope iof the name is shared publicly for consumption but can only be created from within the class 
            private set { _name = value; }
        }

        //defined a shape of a method that the event expect it to handling it when you handle it
        //event handle is a delegate
        public event EventHandler HasSpoken;

        /// <summary>
        /// Method signature- defines the method
        /// i.e. Method that does not return anything, named Speak, takes a string parameters and is publicly accessable
        /// therefore, i couild not have a method that has the same signature in the same class
        /// </summary>
        /// <param name="what"></param>
        public void Speak(string what = "bark") //method pass parameter and parameter can be assigned an argument (string name = vusi)
        {
            if (HasSpoken != null)
                HasSpoken(this, EventArgs.Empty);

        }


        //default argument cannot preseed those that are required, and note: default values are optional
        public void Speak(int times, bool sit = true,string what = "bark")
        {

        }

        //only by this class
        private void Foo() { }

        //only this and derived classes
        protected void Bar() { }

        //only on this assembly
        internal void Draw() { }

    }

    class Poodle : Dog
    {
        void x()
        {
            //sit: using a name arguments
            this.Speak(1, sit: true);
        }
    }
}
