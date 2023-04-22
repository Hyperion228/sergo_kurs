using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace sergo_kurs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {//cписки моделей, понадобятся для дальнейше проверки
        public List<string> mToyota = new List<string>() { "Carola", "Land Cruiser" };
        public List<string> mNissan = new List<string>() { "Patrool", "x-trail" };
        public List<string> mSubaru = new List<string>() { "Forester", "hueta" };
        public List<string> mFerrari = new List<string>() { "Roma", "f8" };
        public List<string> mTesla = new List<string>() { "Model s", "Model y" };
        public Dictionary<string, string> tyt = new Dictionary<string, string>()
        //Списки запчастей, для каждой марки разный список с ценами
        {
            {"Масляный фильтр", "700"},
            {"Воздушный фильтр", "600"},
            {"Солонный фильтр", "800"},
            {"Тормозные диски", "2100"},
            {"Тормозные колодки", "1800"},
            {"Стойки стабилизатора", "2600"},
        };
        public Dictionary<string, string> nissan = new Dictionary<string, string>()
        {
            {"Масляный фильтр", "600"},
            {"Воздушный фильтр", "900"},
            {"Солонный фильтр", "1000"},
            {"Тормозные диски", "4200"},
            {"Тормозные колодки", "1800"},
            {"Стойки стабилизатора", "2600"},
        };
        public Dictionary<string, string> subaru = new Dictionary<string, string>()
        {
            {"Масляный фильтр", "3700"},
            {"Воздушный фильтр", "800"},
            {"Солонный фильтр", "400"},
            {"Тормозные диски", "5100"},
            {"Тормозные колодки", "2800"},
            {"Стойки стабилизатора", "3500"},
        };
        public Dictionary<string, string> ferrari = new Dictionary<string, string>()
        {
            {"Масляный фильтр", "10700"},
            {"Воздушный фильтр", "10600"},
            {"Солонный фильтр", "80000"},
            {"Тормозные диски", "250000"},
            {"Тормозные колодки", "40800"},
            {"Стойки стабилизатора", "56000"},
        };
        public Dictionary<string, string> tesla = new Dictionary<string, string>()
        {
            {"Масляный фильтр", "2400"},
            {"Воздушный фильтр", "1600"},
            {"Солонный фильтр", "8200"},
            {"Тормозные диски", "22100"},
            {"Тормозные колодки", "10800"},
            {"Стойки стабилизатора", "20600"},
        };
        //это выпадающие списки, первый это марки автомобилей, второй запчасти
        public MainWindow()
        {
            InitializeComponent();
            BrandComboBox.ItemsSource = new Person[]
        {
            new Person { Name = "Toyota"},
            new Person { Name = "Nissan" },
            new Person { Name = "Subaru"},
            new Person { Name = "Ferrari"},
            new Person { Name = "Tesla"}
        };
          
            PartsComboBox.ItemsSource = new Person[]
        {
            new Person { Name = "Масляный фильтр"},
            new Person { Name = "Воздушный фильтр" },
            new Person { Name = "Солонный фильтр"},
            new Person { Name = "Тормозные диски"},
            new Person { Name = "Тормозные колодки"},
            new Person { Name = "Стойки стабилизатора"}
        };
            //-------------------------------
            
            
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)//в данном обработчике идет проверка правильно выбраны ли марки 
        {                                                          //и модели машин, если так, то будет выводить ценник в textblock
            //string selectedText = BrandComboBox.Text;            
            //string ModelComboBox = BrandComboBox.Text;
            //string PartsComboBox = BrandComboBox.Text;
            if(BrandComboBox.Text == "Toyota")
            {

                //string value = BrandComboBox.Text;
                //string isExisit = mToyota.Find((value) => value =="");
                if(ModelComboBox.Text == "Carola" ||  ModelComboBox.Text == "Land Cruiser")
                {
                    if (tyt.ContainsKey(PartsComboBox.Text))
                    {
                        string price = tyt[PartsComboBox.Text];
                        textbox.Text = $"{price} рублей";
                       // MessageBox.Show(price);
                    }
                }
                else
                {
                    MessageBox.Show("Вы выбрали неправильное значение");
                }
            }
            else if (BrandComboBox.Text == "Nissan")
            {

                //string value = BrandComboBox.Text;
                //string isExisit = mToyota.Find((value) => value =="");
                if (ModelComboBox.Text == "Patrool" || ModelComboBox.Text == "x-trail")
                {
                    if (nissan.ContainsKey(PartsComboBox.Text))
                    {
                        string price = nissan[PartsComboBox.Text];
                        textbox.Text = $"{price} рублей";
                        // MessageBox.Show(price);
                    }
                }
                else
                {
                    MessageBox.Show("Вы выбрали неправильное значение");
                }
            }
            else if (BrandComboBox.Text == "Subaru")
            {

                //string value = BrandComboBox.Text;
                //string isExisit = mToyota.Find((value) => value =="");
                if (ModelComboBox.Text == "Forester" || ModelComboBox.Text == "Hueta")
                {
                    if (subaru.ContainsKey(PartsComboBox.Text))
                    {
                        string price = subaru[PartsComboBox.Text];
                        textbox.Text = $"{price} рублей";
                        // MessageBox.Show(price);
                    }
                }
                else
                {
                    MessageBox.Show("Вы выбрали неправильное значение");
                }
            }
            else if (BrandComboBox.Text == "Ferrari")
            {

                //string value = BrandComboBox.Text;
                //string isExisit = mToyota.Find((value) => value =="");
                if (ModelComboBox.Text == "Roma" || ModelComboBox.Text == "f8")
                {
                    if (ferrari.ContainsKey(PartsComboBox.Text))
                    {
                        string price = ferrari[PartsComboBox.Text];
                        textbox.Text = $"{price} рублей";
                        // MessageBox.Show(price);
                    }
                }
                else
                {
                    MessageBox.Show("Вы выбрали неправильное значение");
                }
            }
            else if (BrandComboBox.Text == "Tesla")
            {

                //string value = BrandComboBox.Text;
                //string isExisit = mToyota.Find((value) => value =="");
                if (ModelComboBox.Text == "Model s" || ModelComboBox.Text == "Model y")
                {
                    if (tesla.ContainsKey(PartsComboBox.Text))
                    {
                        string price = tesla[PartsComboBox.Text];
                        textbox.Text = $"{price} рублей";
                        // MessageBox.Show(price);
                    }
                }
                else
                {
                    MessageBox.Show("Вы выбрали неправильное значение");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {//в данном обработчике подтверждаете выбор необходимой макри, если выбор марки совпал с моделью, в выпадающем списке будут 
            if (BrandComboBox.Text == "Toyota")//nолько модели от конкретно выбранной марки, если выбрать неверно, появится соощение 
            {                                  //об ошибке, но программа рассчитана так, что такого не должно произойти
                ModelComboBox.ItemsSource = new Person[]
                {
                    new Person { Name = "Carola"},
                    new Person { Name = "Land Cruiser"}
                };
            }
            else if(BrandComboBox.Text == "Nissan")
            {
                ModelComboBox.ItemsSource = new Person[]
                {
                    new Person { Name = "Patrool"},
                    new Person { Name = "x-trail"},
                };
            }
            else if (BrandComboBox.Text == "Subaru")
            {
                ModelComboBox.ItemsSource = new Person[]
                {
                    new Person { Name = "Forester"},
                    new Person { Name = "Hueta"},
                };
            }
            else if (BrandComboBox.Text == "Ferrari")
            {
                ModelComboBox.ItemsSource = new Person[]
                {
                     new Person { Name = "Roma"},
                     new Person { Name = "f8"},
                };
            }
            else if (BrandComboBox.Text == "Tesla")
            {
                ModelComboBox.ItemsSource = new Person[]
                {
                    new Person { Name = "Model s" },
                    new Person { Name = "Model y" }
                };
                
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
        public class Person
        {//получает значения из списков со значениями для выпадающих списков
            public string Name { get; set; } = "";
            //public string Company { get; set; } = "";
            public override string ToString() => $"{Name}";
        }
    }
}
