namespace BlueRayStore
{
    using System;
    using System.Collections.Generic;
    using BlueRayStoreModel;
    using BlueRayStoreModel.Interface;

    public class ViewRender
    {
        public int ItemByPage { get; set; }

        public string RenderHeader(string storeName)
        {
            string renderizedStoreName = $"      {storeName} ";
            renderizedStoreName += "\n________________________________________________________________________________________________________________________";
            int sizeStoreName = renderizedStoreName.Length;
            renderizedStoreName += this.SecondPartRowOptions(sizeStoreName);
            return this.CloseTable() + renderizedStoreName + this.CloseTable();
        }

        public string RenderBody(Page page)
        {
            string messagePageNumberDontExist = "Page 0 can't exist in the catalog";
            string messageMoviePageListEmpty = $"The List is empty in the page {page.PageNumber}";
            int totalItems = page.ItemsByPage;
            if (page.PageNumber == 0)
            {
                throw new ArgumentException(messagePageNumberDontExist);
            }

            if (page.MoviePageList.Count == 0)
            {
                throw new ArgumentException(messageMoviePageListEmpty);
            }

            int numberOfItem = (page.PageNumber * totalItems) - totalItems + 1;
            return this.SettingFormatToShowPage(numberOfItem, page);
        }

        public string RenderOptions(List<string> options)
        {
            int rowsOptionsNotEmpty = options.Count;
            string renderizedOptions = string.Empty;
            for (int countOption = 0; countOption < rowsOptionsNotEmpty; countOption++)
            {
                string renderizedOption = string.Empty;
                renderizedOption += $"   {countOption + 1}  {options[countOption]}";
                int sizeOptions = renderizedOption.Length;
                renderizedOption += this.SecondPartRowOptions(sizeOptions);
                renderizedOptions += renderizedOption;
            }

            int rowsOptionsEmpty = this.ItemByPage - rowsOptionsNotEmpty;
            renderizedOptions += this.EmptyRowOptions(rowsOptionsEmpty);
            return this.CloseTable() + renderizedOptions + this.CloseTable();
        }

        public string RenderMessages(List<string> messages)
        {
            int rowsMessagesNotEmpty = messages.Count;
            string renderizedMessages = string.Empty;
            for (int countMessage = 0; countMessage < rowsMessagesNotEmpty; countMessage++)
            {
                string renderizedOption = string.Empty;
                renderizedOption += $"   {messages[countMessage]}";
                int sizeOptions = renderizedOption.Length;
                renderizedOption += this.SecondPartRowOptions(sizeOptions);
                renderizedMessages += renderizedOption;
            }

            int rowsMessagesEmpty = this.ItemByPage - rowsMessagesNotEmpty;
            renderizedMessages += this.EmptyRowOptions(rowsMessagesEmpty);
            return this.CloseTable() + renderizedMessages + this.CloseTable();
        }

        public string RenderFooter()
        {
            string renderizedStoreFooter = "________________________________________________________________________________________________________________________\n";
            renderizedStoreFooter += $"                 [e] Exit                   [<-] Change pages [->]                    [Backspace] Go back\n";
            renderizedStoreFooter += "________________________________________________________________________________________________________________________";
            string messageForOption = $"\n\n\n\n\n   Choose an option: "; 
            int sizeMessageFooter = renderizedStoreFooter.Length;
            int sizeMessageForOption = messageForOption.Length;
            messageForOption += this.SecondPartRowOptions(sizeMessageForOption);
            renderizedStoreFooter += this.SecondPartRowOptions(sizeMessageFooter);
            renderizedStoreFooter += messageForOption;
            return this.CloseTable() + renderizedStoreFooter + this.CloseTable();
        }

        public string RenderFooterMessages()
        {
            string renderizedStoreFooter = "________________________________________________________________________________________________________________________\n";
            renderizedStoreFooter += $"          [y] Confirm                 [n] Cancel                  [Backspace] Go back                 [e] Exit\n";
            renderizedStoreFooter += "________________________________________________________________________________________________________________________";
            string messageForOption = $"\n\n\n\n\n   Choose an option: ";
            int sizeMessageFooter = renderizedStoreFooter.Length;
            int sizeMessageForOption = messageForOption.Length;
            messageForOption += this.SecondPartRowOptions(sizeMessageForOption);
            renderizedStoreFooter += this.SecondPartRowOptions(sizeMessageFooter);
            renderizedStoreFooter += messageForOption;
            return this.CloseTable() + renderizedStoreFooter + this.CloseTable();
        }

        public string ToStringMovie(IItem item)
        {
            Movie movie = item as Movie;
            string formatToShowMovie = string.Empty;

            if (movie.NameMovie != null)
            {
                if (movie.NameMovie.Length < 31)
                {
                    formatToShowMovie = movie.NameMovie.PadRight(35);
                }
                else
                {
                    var nameMovieReduce = movie.NameMovie.Substring(0, 27);
                    formatToShowMovie = $"{nameMovieReduce}...     ";
                }

                formatToShowMovie += $"{movie.ReleaseDate.ToString().Substring(0, 9)}";
                formatToShowMovie += $"{FormatToShowGenres(movie)}";
            }

            return formatToShowMovie;
        }

        private int ConvertData(string data)
        {
            return Convert.ToInt32(data);
        }

        private string SecondPartRowOptions(int sizeOptions)
        {
            return "\n";
        }

        private string EmptyRowOptions(int rowsOptionsEmpty)
        {
            string optionsEmpty = string.Empty;
            for (int rowsEmpty = 0; rowsEmpty < rowsOptionsEmpty; rowsEmpty++)
            {
                optionsEmpty += "\n";
            }

            return optionsEmpty;
        }

        private string CloseTable()
        {
            string close = string.Empty;
            for (int character = 0; character < 120; character++)
            {
                close += " ";
            }

            return close;
        }

        private string SettingFormatToShowPage(int numberOfItem, Page page)
        {
            string result = "   Name                                  Release Date\t\tGenre\n\n";
            foreach (var movie in page.MoviePageList)
            {
                if (numberOfItem < 10)
                {
                    result += $"    {numberOfItem++}.-{ToStringMovie(movie)}\n";
                }
                else
                {
                    result += $"   {numberOfItem++}.-{ToStringMovie(movie)}\n";
                }
            }

            return result;
        }

        private string FormatToShowGenres(Movie movie)
        {
            string genres = string.Empty;
            if (movie.Genre != null)
            {
                genres = $"{genres}\t\t";
                foreach (string oneGenre in movie.Genre)
                {
                    genres = $"{ genres }{ oneGenre },";
                }

                return genres.TrimEnd(',');
            }

            return genres;
        }
    }
}
