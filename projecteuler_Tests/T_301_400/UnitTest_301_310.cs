namespace projecteuler_Tests.T_301_400
{
    public class UnitTest_301_310
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_301_test()
        {
            if (tasksList.t_List.Length > 300)
                Assert.That(tasksList.t_List[300].answer(), Is.EqualTo("2178309"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_302_test()
        {
            if (tasksList.t_List.Length > 301)
                Assert.That(tasksList.t_List[301].answer(), Is.EqualTo("1170060"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_303_test()
        {
            if (tasksList.t_List.Length > 302)
                Assert.That(tasksList.t_List[302].answer(), Is.EqualTo("1111981904675169"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_304_test()
        {
            if (tasksList.t_List.Length > 303)
                Assert.That(tasksList.t_List[303].answer(), Is.EqualTo("283988410192"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_305_test()
        {
            if (tasksList.t_List.Length > 304)
                Assert.That(tasksList.t_List[304].answer(), Is.EqualTo("18174995535140"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_306_test()
        {
            if (tasksList.t_List.Length > 305)
                Assert.That(tasksList.t_List[305].answer(), Is.EqualTo("852938"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_307_test()
        {
            if (tasksList.t_List.Length > 306)
                Assert.That(tasksList.t_List[306].answer(), Is.EqualTo("0.7311720251"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_308_test()
        {
            if (tasksList.t_List.Length > 307)
                Assert.That(tasksList.t_List[307].answer(), Is.EqualTo("1539669807660924"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_309_test()
        {
            if (tasksList.t_List.Length > 308)
                Assert.That(tasksList.t_List[308].answer(), Is.EqualTo("210139"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_310_test()
        {
            if (tasksList.t_List.Length > 309)
                Assert.That(tasksList.t_List[309].answer(), Is.EqualTo("2586528661783"));
            else
                Assert.Ignore();
        }
    }
}
