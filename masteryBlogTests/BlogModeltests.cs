using masteryBlog.Models;
using System;
using Xunit;

namespace masteryBlogTests
{
    public class BlogModeltests
    {

        BlogModel myBlog = new BlogModel();

        public BlogModeltests()
        {
            myBlog = new BlogModel(1, "test Blog", "My Test Content", "Rob", DateTime.Now, 1, 1);
        }


        [Fact]
        public void CourseConstructor_Sets_Id_on_Blog()
        {
            var result = myBlog.Id;

            Assert.Equal(1, result);
        }

        [Fact]
        public void CourseConstructor_Sets_Title_on_Blog()
        {
            var result = myBlog.Title;

            Assert.Equal("test Blog", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Content_on_Blog()
        {
            var result = myBlog.Content;

            Assert.Equal("My Test Content", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Author_on_Blog()
        {
            var result = myBlog.Author;

            Assert.Equal("Rob", result);
        }
    }
}
