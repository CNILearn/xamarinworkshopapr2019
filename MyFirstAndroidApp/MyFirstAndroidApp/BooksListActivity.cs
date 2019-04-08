using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MyFirstAndroidApp
{
    [Activity(Label = "BooksListActivity")]
    public class BooksListActivity : ListActivity
    {
        private List<Book> _books;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _books = new List<Book>(new BookFactory().GetBooks());

            ListAdapter = new BookListAdapter(this, _books);

            // Create your application here

        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            // base.OnListItemClick(l, v, position, id);

            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.SetMessage($"clicked {_books[position]}").SetTitle(Android.Resource.String.Ok);

            builder.SetNeutralButton(Android.Resource.String.Ok, (sender, e) =>
            {
                // user clicked
            });

            AlertDialog dialog = builder.Create();
            dialog.Show();
        }
    }
}