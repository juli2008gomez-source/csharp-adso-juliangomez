
namespace Reto
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (FormPin pin = new FormPin())
            {
                if (pin.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
            }
        }
    }
}
