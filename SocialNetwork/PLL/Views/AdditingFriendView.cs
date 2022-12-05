using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class AdditingFriendView
    {
        UserService userService;
        public AdditingFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var userAddingFriendData = new UserAdditingngFriendData();

                Console.WriteLine("Введите почтовый адрес друга: ");

                userAddingFriendData.FriendEmail = Console.ReadLine();
                userAddingFriendData.UserId = user.Id;

                this.userService.AddFriend(userAddingFriendData);

                SuccessMessage.Show("Вы добавили пользователя в друзья!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с таким почтовым адресом не существует!");
            }

            catch (Exception)
            {
                AlertMessage.Show("Ошибка при добавлении в друзья!");
            }

        }
    }
}
