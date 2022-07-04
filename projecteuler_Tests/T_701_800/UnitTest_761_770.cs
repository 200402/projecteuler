namespace projecteuler_Tests.T_701_800
{
    public class UnitTest_761_770
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_761_test()
        {
            if (tasksList.t_List.Length > 760)
                Assert.That(tasksList.t_List[760].answer(), Is.EqualTo("5.05505046"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_762_test()
        {
            if (tasksList.t_List.Length > 761)
                Assert.That(tasksList.t_List[761].answer(), Is.EqualTo("nan"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_763_test()
        {
            if (tasksList.t_List.Length > 762)
                Assert.That(tasksList.t_List[762].answer(), Is.EqualTo("nan"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_764_test()
        {
            if (tasksList.t_List.Length > 763)
                Assert.That(tasksList.t_List[763].answer(), Is.EqualTo("255228881"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_765_test()
        {
            if (tasksList.t_List.Length > 764)
                Assert.That(tasksList.t_List[764].answer(), Is.EqualTo("0.2429251641"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_766_test()
        {
            if (tasksList.t_List.Length > 765)
                Assert.That(tasksList.t_List[765].answer(), Is.EqualTo("2613742"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_767_test()
        {
            if (tasksList.t_List.Length > 766)
                Assert.That(tasksList.t_List[766].answer(), Is.EqualTo("783976175"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_768_test()
        {
            if (tasksList.t_List.Length > 767)
                Assert.That(tasksList.t_List[767].answer(), Is.EqualTo("nan"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_769_test()
        {
            if (tasksList.t_List.Length > 768)
                Assert.That(tasksList.t_List[768].answer(), Is.EqualTo("nan"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_770_test()
        {
            if (tasksList.t_List.Length > 769)
                Assert.That(tasksList.t_List[769].answer(), Is.EqualTo("127311223"));
            else
                Assert.Ignore();
        }
    }
}
