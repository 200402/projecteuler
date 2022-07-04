namespace projecteuler_Tests.T_701_800
{
    public class UnitTest_781_790
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_781_test()
        {
            if (tasksList.t_List.Length > 780)
                Assert.That(tasksList.t_List[780].answer(), Is.EqualTo("162450870"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_782_test()
        {
            if (tasksList.t_List.Length > 781)
                Assert.That(tasksList.t_List[781].answer(), Is.EqualTo("318313204"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_783_test()
        {
            if (tasksList.t_List.Length > 782)
                Assert.That(tasksList.t_List[782].answer(), Is.EqualTo("136666597"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_784_test()
        {
            if (tasksList.t_List.Length > 783)
                Assert.That(tasksList.t_List[783].answer(), Is.EqualTo("5833303012576429231"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_785_test()
        {
            if (tasksList.t_List.Length > 784)
                Assert.That(tasksList.t_List[784].answer(), Is.EqualTo("29526986315080920"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_786_test()
        {
            if (tasksList.t_List.Length > 785)
                Assert.That(tasksList.t_List[785].answer(), Is.EqualTo("45594532839912702"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_787_test()
        {
            if (tasksList.t_List.Length > 786)
                Assert.That(tasksList.t_List[786].answer(), Is.EqualTo("202642367520564145"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_788_test()
        {
            if (tasksList.t_List.Length > 787)
                Assert.That(tasksList.t_List[787].answer(), Is.EqualTo("471745499"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_789_test()
        {
            if (tasksList.t_List.Length > 788)
                Assert.That(tasksList.t_List[788].answer(), Is.EqualTo("13431419535872807040"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_790_test()
        {
            if (tasksList.t_List.Length > 789)
                Assert.That(tasksList.t_List[789].answer(), Is.EqualTo("16585056588495119"));
            else
                Assert.Ignore();
        }
    }
}
