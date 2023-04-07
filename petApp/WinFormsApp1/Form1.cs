using static WinFormsApp1.Theme;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // privates
        private Button currentButton;
        private Random random;
        private int tempIndex;

        // Construtor
        public Form1()
        {
            InitializeComponent();
        }

        private Color SelectThemeColor() {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index) {
                random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender) {
            if(btnSender != null) {
                if(currentButton != (Button)btnSender) {
                    
                }
            }
        }
    }
}