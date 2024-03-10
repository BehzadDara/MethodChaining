namespace MethodChaining;

public static class UserMethods
{
        public static User CreateUser()
        {
            return new();
        }

        public static User SetName(this User user, string userName)
        {
            user.Name = userName;
            return user;
        }

        public static User SetAge(this User user, int userAge)
        {
            user.Age = userAge;
            return user;
        }

        public static string ReturnDescription(this User user)
        {
            return $"userName = {user.Name} and userAge = {user.Age}";
        }
}