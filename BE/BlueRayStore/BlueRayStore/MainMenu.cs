namespace BlueRayStore
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using BlueRayStoreModel;
    using BlueRayStoreService;

    public class MainMenu
    {
        private Store store;

        private ConfigurationData Configurations;

        private ViewRender viewRender;

        public MainMenu()
        {
            this.Configurations = new ConfigurationData();
            this.viewRender = new ViewRender();
            this.store = this.GetStoreWithSetting();
            this.SetViewRender();
        }

        public void ShowMainMenu()
        {
            OptionMenu options = new OptionMenu();
            options.AddOption("Show catalog\n");
            options.AddOption("Show movies premiere\n");
            options.AddOption("Upload movies from file .csv");
            Console.SetWindowSize(120, 40);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string mainMenu = ViewController.ShowMainMenu(store.Name, options);
            Console.WriteLine(mainMenu);
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            string buttonPressed = keyPressed.Key.ToString();
            if (keyPressed.Key.ToString() != "E")
            {
                string option = buttonPressed.Substring(buttonPressed.Length - 1, 1);
                try
                {
                    switch (option)
                    {
                        case "1":
                            if (ViewController.ShowCatalog(store.ShowCatalog(), store.Name, keyPressed))
                            {
                                this.ShowMainMenu();
                            }
                            break;
                        case "2":
                            if(ViewController.ShowCatalog(store.ShowPremier(), store.Name, keyPressed))
                            {
                                this.ShowMainMenu();
                            }
                            break;
                        case "3":
                            List<string> messagesUploadFile = new List<string>();
                            messagesUploadFile.Add(" Place your file here:\n");
                            messagesUploadFile.Add(" Directory:     C:/Movie/");
                            messagesUploadFile.Add(" File's name:   movies.csv");
                            ViewController.ShowWindowWithMessages(store.Name, messagesUploadFile);
                            while (keyPressed.Key.ToString() != "E")
                            {
                                switch (keyPressed.Key.ToString())
                                {
                                    case "Backspace":
                                        Console.Clear();
                                        this.ShowMainMenu();
                                        break;
                                    case "Y":
                                        store.ImportMovies();
                                        string message = "Upload file was successful";
                                        List<string> messageResponseToUpload = new List<string> { message };
                                        Console.Clear();
                                        Console.WriteLine(viewRender.RenderMessages(messageResponseToUpload));
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        this.ShowMainMenu();
                                        break;
                                    case "N":
                                        Console.Clear();
                                        this.ShowMainMenu();
                                        break;
                                    default:
                                        break;
                                }

                                keyPressed = Console.ReadKey();
                            }

                            break;
                    }
                }
                catch (Exception exception)
                {
                    Console.Clear();
                    List<string> messageResponseToUpload = new List<string> { exception.Message };
                    Console.WriteLine(viewRender.RenderMessages(messageResponseToUpload));
                    Thread.Sleep(3000);
                    Console.Clear();
                    this.ShowMainMenu();
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private Store GetStoreWithSetting()
        {
            int itemsPerPage = int.Parse(Configurations.GetValueByKey("ItemByPage"));
            string storeName = Configurations.GetValueByKey("StoreName");
            string folder = Configurations.GetValueByKey("CsvFolder");
            string file = Configurations.GetValueByKey("CsvFile");
            int premierDays = int.Parse(Configurations.GetValueByKey("PremierRange"));
            return new Store(storeName, itemsPerPage, folder, file, premierDays);
        }

        private void SetViewRender()
        {
            this.viewRender.ItemByPage = int.Parse(Configurations.GetValueByKey("ItemByPage"));
        }
    }
}
