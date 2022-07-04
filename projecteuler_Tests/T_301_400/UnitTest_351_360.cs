namespace projecteuler_Tests.T_301_400
{
    public class UnitTest_351_360
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_351_test()
        {
            if (tasksList.t_List.Length > 350)
                Assert.That(tasksList.t_List[350].answer(), Is.EqualTo("11762187201804552"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_352_test()
        {
            if (tasksList.t_List.Length > 351)
                Assert.That(tasksList.t_List[351].answer(), Is.EqualTo("378563.260589"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_353_test()
        {
            if (tasksList.t_List.Length > 352)
                Assert.That(tasksList.t_List[352].answer(), Is.EqualTo("1.2759860331"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_354_test()
        {
            if (tasksList.t_List.Length > 353)
                Assert.That(tasksList.t_List[353].answer(), Is.EqualTo("58065134"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_355_test()
        {
            if (tasksList.t_List.Length > 354)
                Assert.That(tasksList.t_List[354].answer(), Is.EqualTo("1726545007"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_356_test()
        {
            if (tasksList.t_List.Length > 355)
                Assert.That(tasksList.t_List[355].answer(), Is.EqualTo("28010159"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_357_test()
        {
            if (tasksList.t_List.Length > 356)
                Assert.That(tasksList.t_List[356].answer(), Is.EqualTo("1739023853137"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_358_test()
        {
            if (tasksList.t_List.Length > 357)
                Assert.That(tasksList.t_List[357].answer(), Is.EqualTo("3284144505"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_359_test()
        {
            if (tasksList.t_List.Length > 358)
                Assert.That(tasksList.t_List[358].answer(), Is.EqualTo("40632119"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_360_test()
        {
            if (tasksList.t_List.Length > 359)
                Assert.That(tasksList.t_List[359].answer(), Is.EqualTo("878825614395267072"));
            else
                Assert.Ignore();
        }
    }
}
