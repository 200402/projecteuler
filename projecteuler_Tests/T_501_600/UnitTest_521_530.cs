namespace projecteuler_Tests.T_501_600
{
    public class UnitTest_521_530
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_521_test()
        {
            if (tasksList.t_List.Length > 520)
                Assert.That(tasksList.t_List[520].answer(), Is.EqualTo("44389811"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_522_test()
        {
            if (tasksList.t_List.Length > 521)
                Assert.That(tasksList.t_List[521].answer(), Is.EqualTo("96772715"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_523_test()
        {
            if (tasksList.t_List.Length > 522)
                Assert.That(tasksList.t_List[522].answer(), Is.EqualTo("37125450.44"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_524_test()
        {
            if (tasksList.t_List.Length > 523)
                Assert.That(tasksList.t_List[523].answer(), Is.EqualTo("2432925835413407847"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_525_test()
        {
            if (tasksList.t_List.Length > 524)
                Assert.That(tasksList.t_List[524].answer(), Is.EqualTo("44.69921807"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_526_test()
        {
            if (tasksList.t_List.Length > 525)
                Assert.That(tasksList.t_List[525].answer(), Is.EqualTo("49601160286750947"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_527_test()
        {
            if (tasksList.t_List.Length > 526)
                Assert.That(tasksList.t_List[526].answer(), Is.EqualTo("11.92412011"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_528_test()
        {
            if (tasksList.t_List.Length > 527)
                Assert.That(tasksList.t_List[527].answer(), Is.EqualTo("779027989"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_529_test()
        {
            if (tasksList.t_List.Length > 528)
                Assert.That(tasksList.t_List[528].answer(), Is.EqualTo("23624465"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_530_test()
        {
            if (tasksList.t_List.Length > 529)
                Assert.That(tasksList.t_List[529].answer(), Is.EqualTo("207366437157977206"));
            else
                Assert.Ignore();
        }
    }
}
