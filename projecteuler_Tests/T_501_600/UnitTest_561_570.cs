namespace projecteuler_Tests.T_501_600
{
    public class UnitTest_561_570
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_561_test()
        {
            if (tasksList.t_List.Length > 560)
                Assert.That(tasksList.t_List[560].answer(), Is.EqualTo("452480999988235494"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_562_test()
        {
            if (tasksList.t_List.Length > 561)
                Assert.That(tasksList.t_List[561].answer(), Is.EqualTo("51208732914368"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_563_test()
        {
            if (tasksList.t_List.Length > 562)
                Assert.That(tasksList.t_List[562].answer(), Is.EqualTo("27186308211734760"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_564_test()
        {
            if (tasksList.t_List.Length > 563)
                Assert.That(tasksList.t_List[563].answer(), Is.EqualTo("12363.698850"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_565_test()
        {
            if (tasksList.t_List.Length > 564)
                Assert.That(tasksList.t_List[564].answer(), Is.EqualTo("2992480851924313898"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_566_test()
        {
            if (tasksList.t_List.Length > 565)
                Assert.That(tasksList.t_List[565].answer(), Is.EqualTo("329569369413585"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_567_test()
        {
            if (tasksList.t_List.Length > 566)
                Assert.That(tasksList.t_List[566].answer(), Is.EqualTo("75.44817535"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_568_test()
        {
            if (tasksList.t_List.Length > 567)
                Assert.That(tasksList.t_List[567].answer(), Is.EqualTo("4228020"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_569_test()
        {
            if (tasksList.t_List.Length > 568)
                Assert.That(tasksList.t_List[568].answer(), Is.EqualTo("21025060"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_570_test()
        {
            if (tasksList.t_List.Length > 569)
                Assert.That(tasksList.t_List[569].answer(), Is.EqualTo("271197444"));
            else
                Assert.Ignore();
        }
    }
}
