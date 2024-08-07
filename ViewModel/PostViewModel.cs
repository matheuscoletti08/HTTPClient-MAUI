using HTTPClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace HTTPClient.ViewModel
{
    public partial class PostViewModel : ObservableObject
    {
        [ObservableProperty]
        List<Post> posts;

        public void getPosts()
        {

        }
    }
}
