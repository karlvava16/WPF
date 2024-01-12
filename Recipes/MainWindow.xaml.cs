using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
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

namespace Recipes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Tuple<string, FlowDocument>> docs;
        public MainWindow()
        {
            InitializeComponent();

            docs = new List<Tuple<string, FlowDocument>>();

            CreateExamples();
            AddToList();
        }

        public void AddToList()
        {
            foreach (var item in docs)
            {
                ls.Items.Add(item.Item1);
            }
        }

        public void CreateExamples()
        {
            try
            {
                Run run1 = new Run("Бограч с грибами и макаронами");
                Paragraph paragraph1 = new Paragraph(new Bold(run1));
                paragraph1.FontSize = 30;
                paragraph1.TextAlignment = TextAlignment.Center;
                paragraph1.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                Paragraph paragraph2 = new Paragraph();
                //картинка
                Image img = new Image();
                BitmapImage bimg = new BitmapImage();
                bimg.BeginInit();
                bimg.UriSource = new Uri("bogrich.jpg", UriKind.Relative);
                bimg.EndInit();
                img.Source = bimg;
                BlockUIContainer block = new BlockUIContainer(img);
                Figure fig = new Figure(block);
                fig.Width = new FigureLength(200);
                fig.HorizontalAnchor = FigureHorizontalAnchor.ContentRight;

                //текст
                Run run2 = new Run();
                run2.Text = "Бограч – венгерский суп-гуляш с мясом, овощами и большим количеством паприки. Этот рецепт – вариант бограча с говядиной: без традиционного сала, а также без картофеля, но с добавлением шампиньонов и макарон, – густой бограч получается ароматным и сытным.";
                paragraph2.Inlines.Add(fig);
                paragraph2.Inlines.Add(run2);

                Run run3 = new Run();
                run3.Text = "Продукты\r\nГовядина (мякоть) - 300-350 г\r\nШампиньоны - 200 г\r\nМакароны (фигурные) - 60 г\r\nПерец болгарский красный - 250 г\r\nПомидоры - 200 г\r\nЛук репчатый - 1 шт.\r\nЧеснок - 3 зубчика\r\nТоматная паста - 50 г\r\nМасло сливочное - 20 г\r\nМасло оливковое - 50 мл\r\nСоль - 1 ч. ложка\r\nПерец черный молотый - 1/4 ч. ложки\r\nПаприка молотая - 1/2 ч. ложки\r\nПаприка копченая молотая - 1/2 ч. ложки\r\nТравы итальянские - 1/2 ч. ложки\r\nЛавровый лист - 2 шт.\r\nПерец душистый горошком - 5 шт.\r\nВода - 1 л\n\n\r\n\r\nПодготовьте необходимые продукты.\r\n\r\nМясо нарежьте небольшими кусочками.\r\n\r\nВ казане или кастрюле с толстым дном разогрейте на среднем огне оливковое масло и добавьте сливочное масло. Выложите мясо и обжарьте примерно 5-7 минут. Затем выньте мясо на тарелку.\r\n\r\nЛук и чеснок и очистите и нарежьте мелкими кубиками.\r\n\r\nГрибы нарежьте небольшими кусочками.\r\n\r\nВ кастрюлю, где обжаривалось мясо, выложите лук и чеснок, всыпьте оба вида паприки и обжарьте 1 минуту.\r\n\r\nДобавьте грибы. Посолите, добавьте молотый перец и итальянские травы.\r\n\r\nОбжарьте 4-5 минут.\r\n\r\nСладкий перец очистите от семян и нарежьте кубиками.\r\n\r\nПомидоры также нарежьте кубиками.\r\n\r\nДобавьте в кастрюлю болгарский перец и обжарьте еще примерно 4-5 минут.\r\n\r\nВерните мясо в кастрюлю. Добавьте лавровый лист и душистый перец горошком.\r\n\r\nДобавьте помидоры и томатную пасту.\r\n\r\nВлейте 1 л воды. Доведите до кипения, накройте крышкой и варите примерно 30 минут.\r\n\r\nДобавьте макароны и варите на пару минут меньше, чем указано в инструкции на упаковке.\r\n\r\nВыключите огонь. Дайте супу настояться под крышкой минут 10.\r\n\r\nРазлейте бограч с грибами и макаронами по тарелкам и подавайте к столу.\r\n\r\nПриятного аппетита!";
                Paragraph paragraph3 = new Paragraph(run3);

                //ссылки
                Hyperlink hp = new Hyperlink(new Run("https://www.russianfood.com/recipes/recipe.php?rid=172074"));
                hp.NavigateUri = new Uri("https://www.russianfood.com/recipes/recipe.php?rid=172074");
                Paragraph paragraph4 = new Paragraph();
                paragraph4.Inlines.Add(hp);

                FlowDocument doc = new FlowDocument();
                doc.Blocks.Add(paragraph1);
                doc.Blocks.Add(paragraph2);
                doc.Blocks.Add(paragraph3);
                doc.Blocks.Add(paragraph4);
                docs.Add(new Tuple<string, FlowDocument>(run1.Text, doc));

            }
            catch
            {

            }

            try
            {
                Run run1 = new Run("Творожный десерт с хурмой");
                Paragraph paragraph1 = new Paragraph(new Bold(run1));
                paragraph1.FontSize = 30;
                paragraph1.TextAlignment = TextAlignment.Center;
                paragraph1.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                Paragraph paragraph2 = new Paragraph();
                //картинка
                Image img = new Image();
                BitmapImage bimg = new BitmapImage();
                bimg.BeginInit();
                bimg.UriSource = new Uri("pirog_hurma.jpg", UriKind.Relative);
                bimg.EndInit();
                img.Source = bimg;
                BlockUIContainer block = new BlockUIContainer(img);
                Figure fig = new Figure(block);
                fig.Width = new FigureLength(200);
                fig.HorizontalAnchor = FigureHorizontalAnchor.ContentRight;

                //текст
                Run run2 = new Run();
                run2.Text = "Если вы любите лёгкие десерты с нежным вкусом, творожный десерт с хурмой наверняка вам понравится. Благодаря тому, что желатин для набухания заливается не водой, а апельсиновым соком, десерт приобретает деликатные цитрусовые нотки.";
                paragraph2.Inlines.Add(fig);
                paragraph2.Inlines.Add(run2);

                Run run3 = new Run();

                run3.Text = "Продукты\r\nТворог 5-9 % – 300 г\r\nХурма (спелая) – 350 г (2 шт.)\r\nСок апельсиновый – 200 мл\r\nЙогурт натуральный – 50 мл\r\nСахарная пудра – 100 мл\r\nЖелатин – 20 г\r\nСахар ванильный – 10 г\r\nЦедра апельсина – 1-2 ч. ложки" +
                    "Подготавливаем продукты.\r\n\r\nСоединяем апельсиновый сок и желатин.\r\n\r\nПеремешиваем и оставляем набухать на 10-15 минут.\r\n\r\nИз хурмы чайной ложкой достаём мякоть.\r\n\r\nТворог выкладываем в миску и перебиваем блендером.\r\n\r\nК творогу добавляем мякоть хурмы.\r\n\r\nПеребиваем творог с хурмой блендером.\r\n\r\nДобавляем йогурт, сахарную пудру и ванильный сахар.\r\n\r\nПеребиваем массу блендером до однородности.\r\n\r\nНабухший желатин растапливаем в микроволновке импульсами по несколько секунд. До кипения не доводим. Добавляем растопленный желатин в творожную массу.\r\n\r\nПеремешиваем миксером или блендером.\r\n\r\nДно разъёмной формы застилаем пергаментом. Выливаем подготовленную массу в форму и отправляем в холодильник до полного застывания на 3-4 часа.\r\n\r\nИзвлекаем желейный десерт из формы, выкладываем на тарелку. С апельсина снимаем цедру с помощью мелкой тёрки. Украшаем десерт апельсиновой цедрой.\r\n\r\nПодаём десерт к столу.\r\n\r\nПриятного аппетита!";
                Paragraph paragraph3 = new Paragraph(run3);

                //ссылки
                Hyperlink hp = new Hyperlink(new Run("https://www.russianfood.com/recipes/recipe.php?rid=172452"));
                hp.NavigateUri = new Uri("https://www.russianfood.com/recipes/recipe.php?rid=172452");
                Paragraph paragraph4 = new Paragraph();
                paragraph4.Inlines.Add(hp);

                FlowDocument doc = new FlowDocument();
                doc.Blocks.Add(paragraph1);
                doc.Blocks.Add(paragraph2);
                doc.Blocks.Add(paragraph3);
                doc.Blocks.Add(paragraph4);
                docs.Add(new Tuple<string, FlowDocument>(run1.Text, doc));

            }
            catch
            {

            }
            try
            {
                Run run1 = new Run("Пирожки с сыром, яйцом и зеленью, из дрожжевого теста на сливках");
                Paragraph paragraph1 = new Paragraph(new Bold(run1));
                paragraph1.FontSize = 30;
                paragraph1.TextAlignment = TextAlignment.Center;
                paragraph1.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                Paragraph paragraph2 = new Paragraph();
                //картинка
                Image img = new Image();
                BitmapImage bimg = new BitmapImage();
                bimg.BeginInit();
                bimg.UriSource = new Uri("Ogurec.jpg", UriKind.Relative);
                bimg.EndInit();
                img.Source = bimg;
                BlockUIContainer block = new BlockUIContainer(img);
                Figure fig = new Figure(block);
                fig.Width = new FigureLength(200);
                fig.HorizontalAnchor = FigureHorizontalAnchor.ContentRight;

                //текст
                Run run2 = new Run();
                run2.Text = "Благодаря тесту, замешанному на сливках, пирожки по этому рецепту получаются особенно нежными и воздушными. Внутри - ароматная и аппетитная начинка из твёрдого сыра, отварного яйца и зелени. Такие круглые пирожки немного напоминают осетинские пироги, но в мини-формате.";
                paragraph2.Inlines.Add(fig);
                paragraph2.Inlines.Add(run2);

                Run run3 = new Run();

                run3.Text = "Продукты (на 8 порций)\r\nДля теста:\r\nСливки 10% – 300 мл\r\nМасло подсолнечное рафинированное – 35 мл + для смазывания поверхностей\r\nМука – 420 г\r\nДрожжи сухие – 2 ч. ложки\r\nСахар – 1 ч. ложка\r\nСоль – 2/3 ч. ложки\r\n*\r\nДля начинки:\r\nСыр полутвёрдый – 250 г\r\nЯйцо – 1 шт.\r\nМасло сливочное – 30 г + для смазывания пирожков\r\nЛук зелёный – 50 г\r\nУкроп свежий – 7 г\r\nЧеснок сушёный – 0,5 ч. ложка\r\nПаприка молотая – 0,25 ч. ложка\r\nСоль – по вкусу" +
                    "Подготавливаем все необходимые продукты.\r\n\r\nСливки подогреваем до тёплой температуры (примерно 40 градусов). Добавляем сахар и дрожжи.\r\n\r\nПеремешиваем и оставляем на 7-10 минут. За это время дрожжи активируются, и на поверхности появится шапочка из пены.\r\n\r\nДобавляем соль. Постепенно всыпаем муку, каждый раз перемешивая ложкой.\r\n\r\nКогда станет трудно мешать ложкой, начинаем вымешивать тесто руками. В процессе замеса, ближе к концу, вливаем подсолнечное рафинированное масло - должно получиться мягкое, но не липкое тесто.\r\n\r\nМиску из-под теста моем, вытираем и смазываем растительным маслом. Возвращаем тесто в миску, накрываем пищевой плёнкой и оставляем на 40 минут в тёплом месте. Подошедшее тесто обминаем и опять оставляем под плёнкой в тепле на 30-40 минут.\r\n\r\nГотовим начинку. Яйцо отвариваем вкрутую (8 минут после закипания воды) и остужаем в холодной воде.\r\n\r\nСыр натираем на крупной тёрке. Яйцо очищаем от скорлупы, натираем на крупной тёрке и отправляем к сыру.\r\n\r\nУкроп и зелёный лук мелко рубим и тоже добавляем в начинку.\r\n\r\nВсыпаем паприку и сушёный чеснок. Начинку перемешиваем, пробуем и при необходимости солим.\r\n\r\nТесто подошло во второй раз. Включаем духовку для разогрева до 200 градусов.\r\n\r\nДелим тесто на 8 одинаковых частей (вес каждого кусочка - примерно 95 г). У нас получится 8 пирожков. Из каждого кусочка формируем шарик.\r\n\r\nРаскатываем шарик теста в лепешку толщиной примерно 7 мм. Выкладываем на лепешку 1/8 часть начинки.\r\n\r\nВ центр начинки выкладываем 1/8 сливочного масла. Края лепёшки подтягиваем вверх и защипываем над начинкой в центре.\r\n\r\nПереворачиваем пирожок защипом вниз и распластываем. В центре пирожка палочкой делаем небольшое отверстие для выхода пара.\r\n\r\nПротивень застилаем пергаментом. Если пергамент не силиконизированный - смазываем его растительным маслом. Выкладываем пирожки на противень.\r\n\r\nОтправляем противень в предварительно разогретую до 200 градусов духовку и выпекаем пирожки с сыром и яйцом 20 минут.\r\n\r\nКак только пирожки достали из духовки - смазываем верх сливочным маслом.\r\n\r\nПирожки с сыром, яйцом и зеленью, из дрожжевого теста на сливках, готовы.\r\n\r\nПодают пирожки горячими, но и остывшие они тоже вкусные!\r\n\r\nПриятного аппетита!";
                Paragraph paragraph3 = new Paragraph(run3);

                //ссылки
                Hyperlink hp = new Hyperlink(new Run("https://www.russianfood.com/recipes/recipe.php?rid=172106"));
                hp.NavigateUri = new Uri("https://www.russianfood.com/recipes/recipe.php?rid=172106");
                Paragraph paragraph4 = new Paragraph();
                paragraph4.Inlines.Add(hp);

                FlowDocument doc = new FlowDocument();
                doc.Blocks.Add(paragraph1);
                doc.Blocks.Add(paragraph2);
                doc.Blocks.Add(paragraph3);
                doc.Blocks.Add(paragraph4);
                docs.Add(new Tuple<string, FlowDocument>(run1.Text, doc));
            }
            catch
            {

            }
        }




        private void GridSplitter_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            GridLength a = new GridLength(0);

            if (list_grid.Width.Value <= 150)
            {
                GridLength b = new GridLength(40);
                But_grid.Width = b;
                list_grid.Width = a;
                Butt.Content = "-->";
                Butt.Visibility = Visibility.Visible;

            }


        }

        private void Butt_Click(object sender, RoutedEventArgs e)
        {
            GridLength a = new GridLength(150);
            list_grid.Width = a;
            Butt.Visibility = Visibility.Hidden;
            GridLength b = new GridLength(0);
            But_grid.Width = b;
        }

        private void ls_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ls.SelectedItem != null)
            {
                DocReader.Document = docs[ls.SelectedIndex].Item2;

            }
        }
    }
}
