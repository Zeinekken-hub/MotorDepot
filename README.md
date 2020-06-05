Technologies: ASP .NET MVC, MS SQL, Entity Framework, Bootstrap 3, JQuery, Ninject, Owin, AspNet.Indentity, AutoMapper

Построить веб-приложение, поддерживающую заданную
функциональность:
1. На основе сущностей предметной области создать классы их
описывающие, соблюдая принципы SOLID. (DI по желанию).
2. Классы и методы должны иметь отражающую их функциональность
названия и должны быть грамотно структурированы в приложении
(folders, namespaces).
3. Оформление кода должно соответствовать C# Code Conventions.
4. Информацию о предметной области хранить в БД, для доступа
использовать Entity Framework. В качестве СУБД использовать MS SQL
(не Compact).
5. Архитектура приложения должна соответствовать шаблону MVC.
6. Выполнить журналирование событий, то есть информацию о
возникающих исключениях и событиях в системе обрабатывать
средствами среды.
7. Код должен содержать комментарии (все классы верхнего уровня,
нетривиальные методы и конструкторы).
8. Уровень доступа к данным должен быть вынесен в отдельный проект.
9. Реализовать разграничение прав доступа пользователей системы к
компонентам приложения (минимум 3 роли).
10. Все поля ввода должны быть с валидацией данных.

Дополнительно, к требованиям изложенным выше, более чем желательно
обеспечить выполнение следующих требований.
1. покрытие юнит-тестами бизнес-логики.
2. Использовать журналирование событий.
3. Обработка исключений.
4. Самостоятельное расширение постановки задачи по
функциональности приветствуется.
Автобаза
Диспетчер создает Рейсы, которые представлены в системе в
виде списка, для которого необходимо реализовать возможность
сортировки по:
номеру рейса;
дате создания рейса;
статусу (открыт, в прогрессе, закрыт, отменен).

Водитель делает Заявку на рейс, в которой указывает
характеристики автомобиля, необходимых для рейса. Диспетчер
просматривает Заявку и назначает на рейс Автомобиль, который
соответствует требованиям и находится в исправном состоянии.
Водитель делает отметку о выполнении рейса и состоянии
автомобиля.
Администратор владеет такими же правами, как и диспетчер,
кроме того может:
регистрировать водителей и диспетчеров в системе;
добавлять/удалять автомобили, редактировать информацию об
автомобилях.
