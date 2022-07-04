namespace projecteuler_Tests.T_301_400
{
    public class UnitTest_341_350
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_341_test()
        {
            if (tasksList.t_List.Length > 340)
                Assert.That(tasksList.t_List[340].answer(), Is.EqualTo("56098610614277014"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_342_test()
        {
            if (tasksList.t_List.Length > 341)
                Assert.That(tasksList.t_List[341].answer(), Is.EqualTo("5943040885644"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_343_test()
        {
            if (tasksList.t_List.Length > 342)
                Assert.That(tasksList.t_List[342].answer(), Is.EqualTo("269533451410884183"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_344_test()
        {
            if (tasksList.t_List.Length > 343)
                Assert.That(tasksList.t_List[343].answer(), Is.EqualTo("65579304332"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_345_test()
        {
            if (tasksList.t_List.Length > 344)
                Assert.That(tasksList.t_List[344].answer(), Is.EqualTo("13938"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_346_test()
        {
            if (tasksList.t_List.Length > 345)
                Assert.That(tasksList.t_List[345].answer(), Is.EqualTo("336108797689259276"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_347_test()
        {
            if (tasksList.t_List.Length > 346)
                Assert.That(tasksList.t_List[346].answer(), Is.EqualTo("11109800204052"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_348_test()
        {
            if (tasksList.t_List.Length > 347)
                Assert.That(tasksList.t_List[347].answer(), Is.EqualTo("1004195061"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_349_test()
        {
            if (tasksList.t_List.Length > 348)
                Assert.That(tasksList.t_List[348].answer(), Is.EqualTo("115384615384614952"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_350_test()
        {
            if (tasksList.t_List.Length > 349)
                Assert.That(tasksList.t_List[349].answer(), Is.EqualTo("84664213"));
            else
                Assert.Ignore();
        }
    }
}
