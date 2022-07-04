namespace projecteuler_Tests.T_301_400
{
    public class UnitTest_321_330
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_321_test()
        {
            if (tasksList.t_List.Length > 320)
                Assert.That(tasksList.t_List[320].answer(), Is.EqualTo("2470433131948040"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_322_test()
        {
            if (tasksList.t_List.Length > 321)
                Assert.That(tasksList.t_List[321].answer(), Is.EqualTo("999998760323313995"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_323_test()
        {
            if (tasksList.t_List.Length > 322)
                Assert.That(tasksList.t_List[322].answer(), Is.EqualTo("6.3551758451"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_324_test()
        {
            if (tasksList.t_List.Length > 323)
                Assert.That(tasksList.t_List[323].answer(), Is.EqualTo("96972774"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_325_test()
        {
            if (tasksList.t_List.Length > 324)
                Assert.That(tasksList.t_List[324].answer(), Is.EqualTo("54672965"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_326_test()
        {
            if (tasksList.t_List.Length > 325)
                Assert.That(tasksList.t_List[325].answer(), Is.EqualTo("1966666166408794329"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_327_test()
        {
            if (tasksList.t_List.Length > 326)
                Assert.That(tasksList.t_List[326].answer(), Is.EqualTo("34315549139516"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_328_test()
        {
            if (tasksList.t_List.Length > 327)
                Assert.That(tasksList.t_List[327].answer(), Is.EqualTo("260511850222"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_329_test()
        {
            if (tasksList.t_List.Length > 328)
                Assert.That(tasksList.t_List[328].answer(), Is.EqualTo("199740353/29386561536000"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_330_test()
        {
            if (tasksList.t_List.Length > 329)
                Assert.That(tasksList.t_List[329].answer(), Is.EqualTo("15955822"));
            else
                Assert.Ignore();
        }
    }
}
