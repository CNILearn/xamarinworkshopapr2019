using BooksServices;
using BooksServices.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsBooksSample.Extensions
{
    public class BookDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate WroxTemplate { get; set; }
        public DataTemplate DefaultTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            DataTemplate selectedTemplate = null;

            switch (item)
            {
                case Book b when b.Publisher == "Wrox Press":
                    selectedTemplate = WroxTemplate;
                    break;
                default:
                    selectedTemplate = DefaultTemplate;
                    break;
            }

            return selectedTemplate;
            //if (item is Book book)
            //{
                
            //}
            //else
            //{
            //    return null;
            //}
        }
    }
}
