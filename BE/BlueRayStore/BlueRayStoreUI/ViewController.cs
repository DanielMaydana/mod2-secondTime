namespace BlueRayStore
{
    using System;
    using System.Collections.Generic;
    using BlueRayStoreModel;

    public static class ViewController
    {
        private static int page = 0;

        private static ViewRender viewRender = new ViewRender();

        public static bool ShowCatalog(List<Page> pages, string storeName, ConsoleKeyInfo keyPressed)
        {
            page = 0;
            bool backSpace = false;
            int maximun = pages.Count - 1;

            while (keyPressed.Key.ToString() != "E")
            {
                if (pages.Count == 1)
                {
                    Show(pages[page], storeName);
                    switch (keyPressed.Key.ToString())
                    {
                        case "Backspace":
                            Console.Clear();
                            return true;
                        default:
                            break;
                    }
                }
                else
                {
                    if (page == 0)
                    {
                        Show(pages[page], storeName);
                        switch (keyPressed.Key.ToString())
                        {
                            case "RightArrow":
                                page += 1;
                                Show(pages[page], storeName);
                                break;
                            case "Backspace":
                                Console.Clear();
                                return true;
                            default:
                                break;
                        }
                    }
                    else if (page == maximun)
                    {
                        Show(pages[page], storeName);

                        switch (keyPressed.Key.ToString())
                        {
                            case "LeftArrow":
                                page -= 1;
                                Show(pages[page], storeName);
                                break;
                            case "Backspace":
                                Console.Clear();
                                return true;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (keyPressed.Key.ToString())
                        {
                            case "RightArrow":
                                page += 1;
                                Show(pages[page], storeName);
                                break;
                            case "LeftArrow":
                                page -= 1;
                                Show(pages[page], storeName);
                                break;
                            case "Backspace":
                                Console.Clear();
                                return true;
                            default:
                                break;
                        }
                    }
                }

                keyPressed = Console.ReadKey();
            }

            Environment.Exit(0);
            return backSpace;
        }

        public static void ShowWindowWithMessages(string storeName, List<string> messages)
        {
            Console.Clear();
            Console.WriteLine(viewRender.RenderHeader(storeName));
            Console.WriteLine(viewRender.RenderMessages(messages));
            Console.WriteLine(viewRender.RenderFooterMessages());
        }

        public static string ShowMainMenu(string storeName, OptionMenu options)
        {
            string mainMenu = string.Empty;
            mainMenu = $"{viewRender.RenderHeader(storeName)}{viewRender.RenderOptions(options.OptionList)}{viewRender.RenderFooter()}";
            return mainMenu;
        }

        private static void Show(Page page, string storeName)
        {
            Console.Clear();
            Console.WriteLine(viewRender.RenderHeader(storeName));
            Console.WriteLine(viewRender.RenderBody(page));
            Console.WriteLine(viewRender.RenderFooter());
        }
    }
}
