namespace projecteuler_Tests.T_701_800
{
    public class UnitTest_751_760
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_751_test()
        {
            if (tasksList.t_List.Length > 750)
                Assert.That(tasksList.t_List[750].answer(), Is.EqualTo("2.223561019313554106173177"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_752_test()
        {
            if (tasksList.t_List.Length > 751)
                Assert.That(tasksList.t_List[751].answer(), Is.EqualTo("5610899769745488"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_753_test()
        {
            if (tasksList.t_List.Length > 752)
                Assert.That(tasksList.t_List[752].answer(), Is.EqualTo("4714126766770661630"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_754_test()
        {
            if (tasksList.t_List.Length > 753)
                Assert.That(tasksList.t_List[753].answer(), Is.EqualTo("785845900"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_755_test()
        {
            if (tasksList.t_List.Length > 754)
                Assert.That(tasksList.t_List[754].answer(), Is.EqualTo("2877071595975576960"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_756_test()
        {
            if (tasksList.t_List.Length > 755)
                Assert.That(tasksList.t_List[755].answer(), Is.EqualTo("607238.610661"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_757_test()
        {
            if (tasksList.t_List.Length > 756)
                Assert.That(tasksList.t_List[756].answer(), Is.EqualTo("75737353"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_758_test()
        {
            if (tasksList.t_List.Length > 757)
                Assert.That(tasksList.t_List[757].answer(), Is.EqualTo("331196954"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_759_test()
        {
            if (tasksList.t_List.Length > 758)
                Assert.That(tasksList.t_List[758].answer(), Is.EqualTo("282771304"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_760_test()
        {
            if (tasksList.t_List.Length > 759)
                Assert.That(tasksList.t_List[759].answer(), Is.EqualTo("172747503"));
            else
                Assert.Ignore();
        }
    }
}
