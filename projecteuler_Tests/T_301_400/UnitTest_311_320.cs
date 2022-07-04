namespace projecteuler_Tests.T_301_400
{
    public class UnitTest_311_320
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_311_test()
        {
            if (tasksList.t_List.Length > 310)
                Assert.That(tasksList.t_List[310].answer(), Is.EqualTo("2466018557"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_312_test()
        {
            if (tasksList.t_List.Length > 311)
                Assert.That(tasksList.t_List[311].answer(), Is.EqualTo("324681947"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_313_test()
        {
            if (tasksList.t_List.Length > 312)
                Assert.That(tasksList.t_List[312].answer(), Is.EqualTo("2057774861813004"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_314_test()
        {
            if (tasksList.t_List.Length > 313)
                Assert.That(tasksList.t_List[313].answer(), Is.EqualTo("132.52756426"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_315_test()
        {
            if (tasksList.t_List.Length > 314)
                Assert.That(tasksList.t_List[314].answer(), Is.EqualTo("13625242"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_316_test()
        {
            if (tasksList.t_List.Length > 315)
                Assert.That(tasksList.t_List[315].answer(), Is.EqualTo("542934735751917735"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_317_test()
        {
            if (tasksList.t_List.Length > 316)
                Assert.That(tasksList.t_List[316].answer(), Is.EqualTo("1856532.8455"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_318_test()
        {
            if (tasksList.t_List.Length > 317)
                Assert.That(tasksList.t_List[317].answer(), Is.EqualTo("709313889"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_319_test()
        {
            if (tasksList.t_List.Length > 318)
                Assert.That(tasksList.t_List[318].answer(), Is.EqualTo("268457129"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_320_test()
        {
            if (tasksList.t_List.Length > 319)
                Assert.That(tasksList.t_List[319].answer(), Is.EqualTo("278157919195482643"));
            else
                Assert.Ignore();
        }
    }
}
