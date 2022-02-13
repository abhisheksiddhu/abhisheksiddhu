namespace WebApplication_MVC.Models
{
    public interface I1 { void Sum(); }

    public interface I2 { void Sum(); void Subtract(); }

    public interface I3 { void Sum(); }

    public class MultipleInterface : I1, I2, I3
    {
        public void Run()
        {
            MultipleInterface multipleInterface = new MultipleInterface();
            multipleInterface.Subtract();
            Run1(multipleInterface);
            Run2(multipleInterface);
            Run3(multipleInterface);
        }

        public void Run1(I1 i1) { i1.Sum(); }
        public void Run2(I2 i2) { i2.Sum(); i2.Subtract(); }
        public void Run3(I3 i3) { i3.Sum(); }

        public void Subtract() { }

        public void Sum()
        {
            Console.WriteLine("");
        }
    }
}
