namespace projecteuler_Tests.T_401_500
{
    public class UnitTest_401_410
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_401_test()
        {
            if (tasksList.t_List.Length > 400)
                Assert.That(tasksList.t_List[400].answer(), Is.EqualTo("281632621"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_402_test()
        {
            if (tasksList.t_List.Length > 401)
                Assert.That(tasksList.t_List[401].answer(), Is.EqualTo("356019862"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_403_test()
        {
            if (tasksList.t_List.Length > 402)
                Assert.That(tasksList.t_List[402].answer(), Is.EqualTo("18224771"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_404_test()
        {
            if (tasksList.t_List.Length > 403)
                Assert.That(tasksList.t_List[403].answer(), Is.EqualTo("1199215615081353"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_405_test()
        {
            if (tasksList.t_List.Length > 404)
                Assert.That(tasksList.t_List[404].answer(), Is.EqualTo("237696125"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_406_test()
        {
            if (tasksList.t_List.Length > 405)
                Assert.That(tasksList.t_List[405].answer(), Is.EqualTo("36813.12757207"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_407_test()
        {
            if (tasksList.t_List.Length > 406)
                Assert.That(tasksList.t_List[406].answer(), Is.EqualTo("39782849136421"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_408_test()
        {
            if (tasksList.t_List.Length > 407)
                Assert.That(tasksList.t_List[407].answer(), Is.EqualTo("299742733"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_409_test()
        {
            if (tasksList.t_List.Length > 408)
                Assert.That(tasksList.t_List[408].answer(), Is.EqualTo("253223948"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_410_test()
        {
            if (tasksList.t_List.Length > 409)
                Assert.That(tasksList.t_List[409].answer(), Is.EqualTo("799999783589946560"));
            else
                Assert.Ignore();
        }
    }
}
