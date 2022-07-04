namespace projecteuler_Tests.T_401_500
{
    public class UnitTest_471_480
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_471_test()
        {
            if (tasksList.t_List.Length > 470)
                Assert.That(tasksList.t_List[470].answer(), Is.EqualTo("1.895093981e31"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_472_test()
        {
            if (tasksList.t_List.Length > 471)
                Assert.That(tasksList.t_List[471].answer(), Is.EqualTo("73811586"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_473_test()
        {
            if (tasksList.t_List.Length > 472)
                Assert.That(tasksList.t_List[472].answer(), Is.EqualTo("35856681704365"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_474_test()
        {
            if (tasksList.t_List.Length > 473)
                Assert.That(tasksList.t_List[473].answer(), Is.EqualTo("9690646731515010"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_475_test()
        {
            if (tasksList.t_List.Length > 474)
                Assert.That(tasksList.t_List[474].answer(), Is.EqualTo("75780067"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_476_test()
        {
            if (tasksList.t_List.Length > 475)
                Assert.That(tasksList.t_List[475].answer(), Is.EqualTo("110242.87794"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_477_test()
        {
            if (tasksList.t_List.Length > 476)
                Assert.That(tasksList.t_List[476].answer(), Is.EqualTo("25044905874565165"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_478_test()
        {
            if (tasksList.t_List.Length > 477)
                Assert.That(tasksList.t_List[477].answer(), Is.EqualTo("59510340"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_479_test()
        {
            if (tasksList.t_List.Length > 478)
                Assert.That(tasksList.t_List[478].answer(), Is.EqualTo("191541795"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_480_test()
        {
            if (tasksList.t_List.Length > 479)
                Assert.That(tasksList.t_List[479].answer(), Is.EqualTo("turnthestarson"));
            else
                Assert.Ignore();
        }
    }
}
