namespace projecteuler_Tests.T_501_600
{
    public class UnitTest_501_510
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_501_test()
        {
            if (tasksList.t_List.Length > 500)
                Assert.That(tasksList.t_List[500].answer(), Is.EqualTo("197912312715"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_502_test()
        {
            if (tasksList.t_List.Length > 501)
                Assert.That(tasksList.t_List[501].answer(), Is.EqualTo("749485217"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_503_test()
        {
            if (tasksList.t_List.Length > 502)
                Assert.That(tasksList.t_List[502].answer(), Is.EqualTo("3.8694550145"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_504_test()
        {
            if (tasksList.t_List.Length > 503)
                Assert.That(tasksList.t_List[503].answer(), Is.EqualTo("694687"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_505_test()
        {
            if (tasksList.t_List.Length > 504)
                Assert.That(tasksList.t_List[504].answer(), Is.EqualTo("714591308667615832"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_506_test()
        {
            if (tasksList.t_List.Length > 505)
                Assert.That(tasksList.t_List[505].answer(), Is.EqualTo("18934502"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_507_test()
        {
            if (tasksList.t_List.Length > 506)
                Assert.That(tasksList.t_List[506].answer(), Is.EqualTo("316558047002627270"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_508_test()
        {
            if (tasksList.t_List.Length > 507)
                Assert.That(tasksList.t_List[507].answer(), Is.EqualTo("891874596"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_509_test()
        {
            if (tasksList.t_List.Length > 508)
                Assert.That(tasksList.t_List[508].answer(), Is.EqualTo("151725678"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_510_test()
        {
            if (tasksList.t_List.Length > 509)
                Assert.That(tasksList.t_List[509].answer(), Is.EqualTo("315306518862563689"));
            else
                Assert.Ignore();
        }
    }
}
