namespace projecteuler_Tests.T_601_700
{
    public class UnitTest_611_620
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_611_test()
        {
            if (tasksList.t_List.Length > 610)
                Assert.That(tasksList.t_List[610].answer(), Is.EqualTo("49283233900"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_612_test()
        {
            if (tasksList.t_List.Length > 611)
                Assert.That(tasksList.t_List[611].answer(), Is.EqualTo("819963842"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_613_test()
        {
            if (tasksList.t_List.Length > 612)
                Assert.That(tasksList.t_List[612].answer(), Is.EqualTo("0.3916721504"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_614_test()
        {
            if (tasksList.t_List.Length > 613)
                Assert.That(tasksList.t_List[613].answer(), Is.EqualTo("130694090"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_615_test()
        {
            if (tasksList.t_List.Length > 614)
                Assert.That(tasksList.t_List[614].answer(), Is.EqualTo("108424772"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_616_test()
        {
            if (tasksList.t_List.Length > 615)
                Assert.That(tasksList.t_List[615].answer(), Is.EqualTo("310884668312456458"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_617_test()
        {
            if (tasksList.t_List.Length > 616)
                Assert.That(tasksList.t_List[616].answer(), Is.EqualTo("1001133757"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_618_test()
        {
            if (tasksList.t_List.Length > 617)
                Assert.That(tasksList.t_List[617].answer(), Is.EqualTo("634212216"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_619_test()
        {
            if (tasksList.t_List.Length > 618)
                Assert.That(tasksList.t_List[618].answer(), Is.EqualTo("857810883"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_620_test()
        {
            if (tasksList.t_List.Length > 619)
                Assert.That(tasksList.t_List[619].answer(), Is.EqualTo("1470337306"));
            else
                Assert.Ignore();
        }
    }
}
