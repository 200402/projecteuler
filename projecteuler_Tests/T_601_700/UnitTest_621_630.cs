namespace projecteuler_Tests.T_601_700
{
    public class UnitTest_621_630
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_621_test()
        {
            if (tasksList.t_List.Length > 620)
                Assert.That(tasksList.t_List[620].answer(), Is.EqualTo("11429712"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_622_test()
        {
            if (tasksList.t_List.Length > 621)
                Assert.That(tasksList.t_List[621].answer(), Is.EqualTo("3010983666182123972"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_623_test()
        {
            if (tasksList.t_List.Length > 622)
                Assert.That(tasksList.t_List[622].answer(), Is.EqualTo("3679796"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_624_test()
        {
            if (tasksList.t_List.Length > 623)
                Assert.That(tasksList.t_List[623].answer(), Is.EqualTo("984524441"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_625_test()
        {
            if (tasksList.t_List.Length > 624)
                Assert.That(tasksList.t_List[624].answer(), Is.EqualTo("551614306"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_626_test()
        {
            if (tasksList.t_List.Length > 625)
                Assert.That(tasksList.t_List[625].answer(), Is.EqualTo("695577663"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_627_test()
        {
            if (tasksList.t_List.Length > 626)
                Assert.That(tasksList.t_List[626].answer(), Is.EqualTo("220196142"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_628_test()
        {
            if (tasksList.t_List.Length > 627)
                Assert.That(tasksList.t_List[627].answer(), Is.EqualTo("210286684"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_629_test()
        {
            if (tasksList.t_List.Length > 628)
                Assert.That(tasksList.t_List[628].answer(), Is.EqualTo("626616617"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_630_test()
        {
            if (tasksList.t_List.Length > 629)
                Assert.That(tasksList.t_List[629].answer(), Is.EqualTo("9669182880384"));
            else
                Assert.Ignore();
        }
    }
}
