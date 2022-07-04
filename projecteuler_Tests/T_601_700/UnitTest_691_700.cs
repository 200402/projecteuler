namespace projecteuler_Tests.T_601_700
{
    public class UnitTest_691_700
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_691_test()
        {
            if (tasksList.t_List.Length > 690)
                Assert.That(tasksList.t_List[690].answer(), Is.EqualTo("11570761"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_692_test()
        {
            if (tasksList.t_List.Length > 691)
                Assert.That(tasksList.t_List[691].answer(), Is.EqualTo("842043391019219959"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_693_test()
        {
            if (tasksList.t_List.Length > 692)
                Assert.That(tasksList.t_List[692].answer(), Is.EqualTo("699161"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_694_test()
        {
            if (tasksList.t_List.Length > 693)
                Assert.That(tasksList.t_List[693].answer(), Is.EqualTo("1339784153569958487"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_695_test()
        {
            if (tasksList.t_List.Length > 694)
                Assert.That(tasksList.t_List[694].answer(), Is.EqualTo("0.1017786859"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_696_test()
        {
            if (tasksList.t_List.Length > 695)
                Assert.That(tasksList.t_List[695].answer(), Is.EqualTo("436944244"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_697_test()
        {
            if (tasksList.t_List.Length > 696)
                Assert.That(tasksList.t_List[696].answer(), Is.EqualTo("4343871.06"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_698_test()
        {
            if (tasksList.t_List.Length > 697)
                Assert.That(tasksList.t_List[697].answer(), Is.EqualTo("57808202"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_699_test()
        {
            if (tasksList.t_List.Length > 698)
                Assert.That(tasksList.t_List[698].answer(), Is.EqualTo("37010438774467572"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_700_test()
        {
            if (tasksList.t_List.Length > 699)
                Assert.That(tasksList.t_List[699].answer(), Is.EqualTo("1517926517777556"));
            else
                Assert.Ignore();
        }
    }
}
