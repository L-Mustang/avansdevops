using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using avansdevops;
using avansdevops.BacklogItems;
using avansdevops.User;

namespace avansdevopsTests
{

    [TestClass]
    public class ForumTests
    {
        Forum f1;
        BacklogItem backlogItem1;
        ForumThread forumThread1;
        ForumPost forumPost1;

        UserFactory devFactory = new DeveloperFactory("Dev", "developer", "dev@example.com");
        IUser? dev;

        [TestInitialize]
        public void Setup()
        {            
            f1 = new Forum();
            backlogItem1 = new BacklogItem(1, "BacklogItem1", dev);
            forumThread1 = new ForumThread("title1", backlogItem1);
            forumPost1 = new ForumPost("Content1", 1);

            dev = devFactory.CreateUser();
        }

        

        [TestMethod]
        public void Test_ForumCreate()
        {
            // Act
            Forum f = new Forum();

            // Assert
            f.Should().BeOfType(typeof(Forum));
        }

        [TestMethod]
        public void Test_ForumThreadCreate()
        {
            // Arrange

            // Act
            ForumThread forumThread = new ForumThread("title", backlogItem1);

            // Assert
            forumThread.Should().BeOfType<ForumThread>();
        }

        [TestMethod]
        public void Test_ForumAddThread()
        {
            // Act
            f1.AddThread(forumThread1);

            // Assert
            f1.GetThreads()[0].Should().Be(forumThread1);
        }

        [TestMethod]
        public void Test_ForumPostCreate()
        {
            // Arrange
            string content = "content";

            // Act
            ForumPost fp = new ForumPost(content, 1);

            // Assert
            fp.Should().BeOfType<ForumPost>();

        }

        [TestMethod]
        public void Test_ForumThreadAddPost()
        {
            // Arrange
            f1.AddThread(forumThread1);

            // Act
            forumThread1.AddPost(forumPost1);

            // Assert
            forumThread1.GetPosts()[0].Should().Be(forumPost1);
        }

    }
}
