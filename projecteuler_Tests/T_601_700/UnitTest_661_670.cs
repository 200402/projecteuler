namespace projecteuler_Tests.T_601_700
{
    public class UnitTest_661_670
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_661_test()
        {
            if (tasksList.t_List.Length > 660)
                Assert.That(tasksList.t_List[660].answer(), Is.EqualTo("646231.2177"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_662_test()
        {
            if (tasksList.t_List.Length > 661)
                Assert.That(tasksList.t_List[661].answer(), Is.EqualTo("860873428"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_663_test()
        {
            if (tasksList.t_List.Length > 662)
                Assert.That(tasksList.t_List[662].answer(), Is.EqualTo("1884138010064752"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_664_test()
        {
            if (tasksList.t_List.Length > 663)
                Assert.That(tasksList.t_List[663].answer(), Is.EqualTo("35295862"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_665_test()
        {
            if (tasksList.t_List.Length > 664)
                Assert.That(tasksList.t_List[664].answer(), Is.EqualTo("11541685709674"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_666_test()
        {
            if (tasksList.t_List.Length > 665)
                Assert.That(tasksList.t_List[665].answer(), Is.EqualTo("0.48023168"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_667_test()
        {
            if (tasksList.t_List.Length > 666)
                Assert.That(tasksList.t_List[666].answer(), Is.EqualTo("1.5276527928"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_668_test()
        {
            if (tasksList.t_List.Length > 667)
                Assert.That(tasksList.t_List[667].answer(), Is.EqualTo("2811077773"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_669_test()
        {
            if (tasksList.t_List.Length > 668)
                Assert.That(tasksList.t_List[668].answer(), Is.EqualTo("56342087360542122"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_670_test()
        {
            if (tasksList.t_List.Length > 669)
                Assert.That(tasksList.t_List[669].answer(), Is.EqualTo("551055065"));
            else
                Assert.Ignore();
        }
    }
}
