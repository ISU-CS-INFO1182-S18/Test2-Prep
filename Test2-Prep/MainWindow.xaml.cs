using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test2_Prep {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            MoveHero();

            //List<INoisy> noisyThingies = new List<INoisy>();
            //noisyThingies.Add(new Cat());
            //noisyThingies.Add(new Dog());
            //noisyThingies.Add(new Badger());
            //noisyThingies.Add(new Sloth());
            //noisyThingies.Add(new Cat());
            //noisyThingies.Add(new Badger());
            //noisyThingies.Add(new Dog());
            //noisyThingies.Add(new Sloth());
            //noisyThingies.Add(new Cat());
            //noisyThingies.Add(new Badger());
            //noisyThingies.Add(new Vehicle());

            //foreach (INoisy n in noisyThingies)
            //    n.Shout();

            List<Control> conts = new List<Control>();
            conts.Add(new Button());
            conts.Add(new ListBox());
            conts.Add(new TextBox());
            conts.Add(new Label());

            foreach (Control c in conts) {
                c.Name = "";
            }

            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat(){TagNumber = 0});
            animals.Add(new Dog(){TagNumber = 14});
            animals.Add(new Badger(){TagNumber = 21});
            animals.Add(new Sloth(){TagNumber = 128});
            animals.Add(new Cat(){TagNumber = 129});
            animals.Add(new Badger(){TagNumber = 130});
            animals.Add(new Dog(){TagNumber = 143});
            animals.Add(new Sloth(){TagNumber = 99});
            animals.Add(new Cat(){TagNumber = 290});
            animals.Add(new Badger(){TagNumber = 1});
            //animals.Add(new Vehicle());

            foreach (Animal a in animals)
                a.Jump();


            animals.Sort();

           int maxAni = animals.Max(ani => ani.TagNumber );
            int minBob =  animals.Min(bob => bob.TagNumber);
           double avgSally = animals.Average(sally => sally.TagNumber);
        int sumHarold =    animals.Sum(harold => harold.TagNumber);
            var cats =  animals.Where(randall => randall.GetType() == typeof(Cat));
            var oldies = animals.Where(randall => randall.TagNumber > 50);
            var trips = animals.Where(randall => randall.TagNumber >= 100 && randall.TagNumber <= 999);

            var isZip = animals.FirstOrDefault(randall => randall.TagNumber == 999);
            //animals.First()

            int countOfCats = cats.Count();


        }
        /// <summary>
        /// Moves Hero Somewhere
        /// </summary>
        private void MoveHero() {



        }

        private abstract class Animal : INoisy, IComparable<Animal> {
            public abstract void Jump();
            private int _TagNumber;

            public int TagNumber {
                get { return _TagNumber; }
                set { _TagNumber = value; }
            }

            public override string ToString() {
                return string.Format("{0} || {1}",
                    base.ToString(), TagNumber);
            }

            public abstract string Shout();

            public int CompareTo(Animal other) {
                //if(this.TagNumber > other.TagNumber) {
                //    return 1;
                //}else if( this.TagNumber < other.TagNumber) {
                //    return -1;
                //} else {
                //    return 0;
                //}
                return other.TagNumber.CompareTo(this.TagNumber);
            }

            //public int CompareTo(object obj) {
            //    throw new NotImplementedException();
            //}
        }

        private class Cat : Animal {
            public override void Jump() {
                // wiggle
            }
            public override string Shout() {
                return "Meowwww!";
            }
            
        }

        private class Dog : Animal, IBarky {

            public override void Jump() {
                // wiggle
            }
            public override string Shout() {
                return "Arroooo!";
            }
            public string Bark() {
                return "Woof";
            }
        }

        private class Badger : Animal, IBarky {
            public override void Jump() {
                // wiggle
            }
            public override string Shout() {
                return "Snarl!";
            }

            public string Bark() {
                return "bark";
            }

        }

        private class Sloth : Animal {
            public override void Jump() {
                // attempts
            }
            public override string Shout() {
                return "HHHHHHEEEEEEELLLLLLLLLLLLLLOOOOOOOOOO!";
            }
        }

        private interface INoisy {
            string Shout();
        }

        private interface IBarky {
            string Bark();
        }


        private class Vehicle: INoisy {
            public string Shout() {
                return "Varoom!";
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e) {
            if (e.Key == Key.J) {
                BtnPressMe_Click(null, null);
            }
            MessageBox.Show("You pressed a key; it was " + e.Key );
        }

        private void BtnPressMe_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("You pressed the Button");

        }
    }
}
