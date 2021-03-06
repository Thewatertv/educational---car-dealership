USE [Motor_show]
GO


INSERT [refbok_car_models] ([name]) VALUES (N'veloster  '),
 (N'I30       '),
 (N'veloster N'),
 (N'I30 N     '),
 (N'Creta     '),
 (N'solaris   '),
 (N'I10       '),
 (N'I20       '),
 (N'Santafe   '),
 (N'Polosad   ')

GO


INSERT [Generations_car_model] ([id_car_model], [Generations]) VALUES (1, N'Поколение 1                   '),
 (1, N'Ппоколение 1 рестайлинг       '),
 (1, N'Поколение 2                   '),
 (2, N'Поколение 1                   '),
 (2, N'Ппоколение 1 рестайлинг       '),
 (2, N'Ппоколение 2 рестайлинг       '),
 (4, N'Поколение 1                   '),
 (5, N'Поколение 1                   '),
 (6, N'Поколение 1                   '),
 (6, N'Ппоколение 1 рестайлинг       '),
 (6, N'Ппоколение 2 рестайлинг       '),
 (6, N'Ппоколение 3 рестайлинг       '),
 (6, N'Поколение 2                   '),
 (6, N'Ппоколение 2 рестайлинг       '),
 (6, N'Ппоколение 3                  '),
 (9, N'Поколение 1                   '),
 (9, N'Ппоколение 1 рестайлинг       '),
 (9, N'Поколение 2                   '),
 (9, N'Ппоколение 3                  '),
 (10, N'Поколение 1                   ')

GO


INSERT  [refbook_body_type] ([name], [Number_doors], [frame], [number_seats]) VALUES (N'Компактый кросовер            ', 5, 0, 5),
 (N'Внедорожник                   ', 5, 1, 7),
 (N'Купе                          ', 2, 0, 2),
 (N'Сидан                         ', 4, 0, 5),
 (N'Тарго                         ', 2, 0, 2),
 (N'              Хетчбэк         ', 5, 0, 4)

GO


INSERT  [refbook_Colour] ([name], [color_code]) VALUES (N'Indigo Blue Pearl             ', N'3U, Y3U                       '),
 (N'Absolute Black Pearl          ', N'ABP                           '),
 (N'Admiral Blue Pearl            ', N'B2R                           '),
 (N'Aurora Blue Pearl Metallic    ', N'D3/U1                         '),
 (N'Beige                         ', N'WT                            '),
 (N'CHALK WHITE                   ', N'P6W                           '),
 (N'GALACTIC GREY                 ', N'R3G                           '),
 (N'PULSE RED                     ', N'Y2R, Y21                      '),
 (N'SILVER BLUE                   ', N'VEA                           '),
 (N'WHITE CRYSTAL                 ', N'PGU                           ')

GO


INSERT  [refbook_drive_unit] ([name]) VALUES (N'Полный через муфту            '),
  (N'Передний                      '),
  (N'Задний                        '),
  (N'Полный 50\50                  ')

GO


INSERT  [refbook_engine] ([volume], [type], [power]) VALUES (2.4, N'Бенизиновый         ', 200),
 (2, N'Бенизиновый         ', 150),
 (1.6, N'Бенизиновый         ', 123),
 (1.4, N'Бенизиновый         ', 100),
 (2, N'Турбо дизель        ', 150),
 (2.2, N'Турбо дизель        ', 180),
 (2.5, N'Турбо дизель        ', 200),
 (3, N'Турбо дизель        ', 185),
 (1.5, N'Турбо бензин        ', 200),
 (2, N'Турбо бензин        ', 250),
 (6, N'233                 ', 100)

GO


INSERT  [refbook_headlight type] ([name]) VALUES (N'Линзованияе галогеновые       '),
  (N'Галогеновые                   '),
  (N'Ксенон                        '),
  (N'Светодиодные                  ')

GO


INSERT  [refbook_wheel_size] ([name]) VALUES (N'r14       '),
 (N'r15       '),
 (N'r16       '),
 (N'r17       '),
 (N'r18       '),
 (N'r19       '),
 (N'r20       '),
 (N'r21       '),
 (N'r22       ')

GO


INSERT  [refbool_equipment] ([engine], [drive_unit], [headlight_type], [wheel_size], [Colour], [body_type]) VALUES (1, 1, 1, 5, 1, NULL),
 (3, 2, 2, 3, 2, NULL),
 (2, 2, 2, 4, 3, NULL),
 (3, 3, 2, 5, 4, NULL),
 (2, 4, 3, 5, 2, NULL),
 (1, 3, 1, 2, 1, NULL),
 (5, 1, 1, 6, 2, NULL),
 (2, 3, 3, 4, 3, NULL),
 (8, 2, 2, 3, 2, NULL),
 (6, 2, 3, 5, 2, NULL),
 (3, 1, 2, 4, 1, NULL),
 (7, 3, 3, 3, 6, NULL),
 (3, 2, 1, 3, 3, NULL),
 (3, 1, 3, 2, 4, NULL),
 (4, 2, 2, 4, 6, NULL),
 (3, 3, 3, 3, 5, NULL),
 (6, 2, 3, 5, 3, NULL),
 (4, 3, 2, 3, 2, NULL),
 (2, 1, 2, 4, 2, NULL),
 (5, 2, 1, 5, 6, NULL),
 (3, 3, 1, 4, 2, NULL),
 (3, 2, 2, 2, 3, NULL),
 (5, 2, 3, 4, 6, NULL),
 (1, 4, 2, 5, 6, NULL),
 (4, 3, 1, 3, 1, NULL),
 (5, 3, 3, 2, 4, NULL),
 (6, 2, 1, 4, 2, NULL),
 (3, 1, 2, 3, 2, NULL),
 (4, 3, 2, 4, 3, NULL),
 (2, 4, 1, 5, 1, NULL)

GO

SET IDENTITY_INSERT  [refbook_document]  ON
INSERT  [refbook_document] ([id], [Name]) VALUES (1, N'Паспорт   ')

GO
SET IDENTITY_INSERT  [refbook_document]  OFF 

INSERT  [Client] ([Name], [Surname], [Middle_name]) VALUES (N'Феост               ', N'Трифонов            ', N'Викторович          '),
 (N'Зариб               ', N'Жданов              ', N'Юрьевич             '),
 (N'Манька              ', N'Добровольский       ', N'Николаевна          '),
 (N'Мехеммед            ', N'Ленский             ', N'Альбертович         '),
 (N'Ефимия              ', N'Точеная             ', N'Максимовна          ')

GO
INSERT  [Client_Personal_data] ([id], [Document], [Series], [Number], [When_issued], [Issued_by_whom]) VALUES (1, 1, N'4270      ', 120399, N'21.06.2012', N'Отделением УФМС России по г. Невинномысск                                                           '),
 (2, 1, N'4850      ', 593322, N'12.07.2011', N'Отделением УФМС России в г. Нефтекамск                                                              '),
 (3, 1, N'4038      ', 743901, N'15.11.2019', N'Отделом УФМС России по г. Екатеринбург                                                              '),
 (4, 1, N'4915      ', 770555, N'27.01.2016', N'ОВД России по г. Ярославль                                                                          '),
 (5, 1, N'4290      ', 852784, N'19.10.2013', N'ОУФМС России по г. Магнитогорск                                                                     ')
GO


INSERT  [refbook_equipments] ([Name], [Price]) VALUES (N'Тонировка                                                                                           ', 3000.0000),
 (N'Сигнализация Cenmax Vigilant V-12D                                                                  ', 4000.0000),
 (N'Сигнализация StarLine E66 BT MINI                                                                   ', 6000.0000),
 (N'Сигнализация StarLine A63 2CAN+2LIN ECO                                                             ', 7500.0000),
 (N'Сигнализация Pandora DX 9X                                                                          ', 9500.0000),
 (N'Сигнализация ZONT ZTC-710 slave                                                                     ', 13000.0000),
 (N'Сигнализация Pandora DXL 4970                                                                       ', 50000.0000),
 (N'Защита картеа                                                                                       ', 2000.0000),
 (N'Чехлы                                                                                               ', 5000.0000),
 (N'Кожаные чехлы                                                                                       ', 34000.0000),
 (N'Сетка в бампер                                                                                      ', 2000.0000),
 (N'Камера заднего вида                                                                                 ', 40000.0000),
 (N'Камера заднего вида                                                                                 ', 70000.0000),
 (N'Камера заднего вида                                                                                 ', 120000.0000),
 (N'Керамика                                                                                            ', 300000.0000),
 (N'Шумоизоляция                                                                                        ', 380000.0000),
 (N'Шумоизоляция                                                                                        ', 790000.0000),
 (N'Шумоизоляция                                                                                        ', 123000.0000),
 (N'Резина зимния                                                                                       ', 1500000.0000),
 (N'Резина летния                                                                                       ', 1200000.0000)

GO

INSERT  [Staff] ([Name], [Surname], [Middle_name]) VALUES (N'Игнатий   ', N'Зарица    ', N'Федорович '),
  (N'Янович    ', N'Настасья  ', N'Валерьевна'),
  (N'Александр ', N'Кабисов   ', N'Романович '),
  (N'Сюзанна   ', N'Собчак    ', N'Арсеньевна'),
  (N'Илья      ', N'Хватов    ', N'Антонович '),
  (N'Безрукова ', N'Виктория  ', N'Лукьяновна'),
  (N'Ника      ', N'Цаплина   ', N'Власовна  ')

GO


INSERT  [refbook_statys_car] ([name]) VALUES (N'Забронирована       '),
 (N'Продана             '),
 (N'На складе           '),
 (N'Заказана на заводе  ')

GO


INSERT  [Status_car_models] ([id_car_models], [Status], [id_Generations], [equipment]) VALUES (1, 1, 1, 1),
 (2, 3, 2, 2),
 (3, 3, 3, 3),
 (4, 4, 4, 4),
 (5, 2, 2, 2),
 (1, 2, 3, 2),
 (3, 1, 4, 1),
 (2, 1, 2, 4),
 (1, 4, 1, 4),
 (4, 3, 4, 1),
 (1, 3, 2, 2),
 (3, 2, 1, 2),
 (5, 1, 3, 1),
 (3, 1, 4, 3),
 (6, 3, 2, 2),
 (4, 2, 1, 3)

GO


INSERT  [buying_car] ([car], [staff], [car_Price], [Discount], [Final_price], [date_transaction]) VALUES (2, 1, 1900000.0000, N'0         ', 1900000.0000, N'12.12.2019'),
 (3, 2, 1000000.0000, N'0         ', 1000000.0000, N'11.02.2020'),
 (4, 1, 6000000.0000, N'10%       ', 5400000.0000, N'11.12.2020')

GO

SET IDENTITY_INSERT  [Additional_equipment] ON
INSERT  [Additional_equipment] ([id_buying _car], [id_Additional equipment], [Price]) VALUES (1, 1, 3000.0000),
 (1, 7, 50000.0000),
 (1, 15, 300000.0000),
 (1, 19, 1500000.0000)

GO
SET IDENTITY_INSERT  [Additional_equipment]  OFF 

INSERT  [refbook_Positions] ([name]) VALUES (N'Менеджер            '),
 (N'Топ менеджер        '),
 (N'Директор            '),
 (N'Зам директора       '),
 (N'Бухгалтер           '),
 (N'Маркетолог          '),
 (N'Старший маркетолог  ')

GO


INSERT  [refbook_status] ([Description]) VALUES (N'В отпуске '),
  (N'Уволен    '),
  (N'Дикрет    '),
  (N'Работает  ')
 
GO


INSERT  [LCA] ([Level], [Description]) VALUES (N'1         ', N'Психолог                                                                                       '),
 (N'2         ', N'Стоматология                                                                                        '),
 (N'3         ', N'Полная медцинская страховака                                                                        ')

GO


INSERT  [Staff_goal] ([Date of issue of the goal], [Goal end date], [Goal]) VALUES (N'11.01.2021', N'01.09.2021', N'1000 продаж                                       '),
 (N'11.01.2021', N'01.09.2021', N'1000 продаж                                       '),
 (N'11.01.2021', N'01.09.2021', N'Увеличения прибыли на 10 процентов                '),
 (N'11.01.2021', N'01.09.2021', N'Расширение персонала до 30 человек                '),
 (N'11.01.2021', N'01.09.2021', N'Изчения курса х                                   '),
 (N'11.01.2021', N'01.09.2021', N'Увеличения конверсии с рекаламы на 20 процентов   '),
 (N'11.01.2021', N'01.09.2021', N'1200 продаж                                       ')

GO
INSERT  [Staff_Career] ([id_staff], [Experience], [id_Position], [id_Goals], [Date of employment], [Date of dismissal], [id_Status], [Privileges]) VALUES (1, 3, 1, 1, N'09.11.2017', NULL, 1, 1),
 (2, 1, 1, 2, N'19.02.2018', NULL, 2, 1),
 (3, 0, 3, 3, N'03.03.2019', NULL, 3, 1),
 (4, 0, 4, 4, N'01.08.2016', NULL, 1, 3),
 (5, 3, 5, 5, N'02.12.2018', N'09.12.2019', 1, 2),
 (6, 23, 6, 6, N'11.11.2019', NULL, 4, 1),
 (7, 4, 2, 7, N'04.12.2016', NULL, 4, 2)
GO

SET IDENTITY_INSERT  [Client_Contact_information]  ON
INSERT  [Client_Contact_information] ([id], [address], [telephone 1], [telephone 2]) VALUES (1, N'347659, г. Уруссу, ул. Наставников пр-кт, дом 110, квартира 168                                     ', N'+7 (906) 846-35-30', NULL),
 (2, N'399621, г. Крылово, ул. Маршала Мерецкова, дом 146, квартира 935                                    ', N'+7 (941) 127-80-58', NULL),
 (3, N'366823, г. Чистые пруды, ул. Радиаторская 1-я, дом 1, квартира 147                                  ', N'+7 (943) 241-67-69', NULL),
 (4, N'446205, г. Хиславичи, ул. Тимирязева, дом 84, квартира 156                                          ', N'+7 (950) 885-25-48', NULL),
 (5, N'386241, г. Кытманово, ул. Героев Труда, дом 70, квартира 21                                         ', N'+7 (905) 053-10-72', NULL)

GO
SET IDENTITY_INSERT  [Client_Contact_information]  OFF 

INSERT  [Client's_transactions] ([id_client], [id_deal]) VALUES (1, 1),
 (2, 2),
 (3, 3)
GO
INSERT  [Staff_Contact_information] ([id], [adress], [telephone 1], [telephone 2]) VALUES (1, N'Россия, г. Челябинск, Лесной пер., д. 1 кв.68                                                       ', N'+7 (971) 770-19-33', N'+7 (971) 770-77-70'),
 (2, N'Россия, г. Тула, Радужная ул., д. 2 кв.181                                                          ', N'+7 (918) 458-27-62', N'+7 (971) 770-77-71'),
 (3, N'Россия, г. Жуковский, Парковая ул., д. 3 кв.157                                                     ', N'+7 (951) 363-77-38', N'+7 (971) 770-77-72'),
 (4, N'Россия, г. Волжский, Солнечная ул., д. 4 кв.10                                                      ', N'+7 (953) 358-71-28', N'+7 (971) 770-77-73'),
 (5, N'Россия, г. Сочи, Дружная ул., д. 20 кв.167                                                          ', N'+7 (988) 714-06-86', N'+7 (971) 770-77-74'),
 (6, N'Россия, г. Кемерово, Западная ул., д. 16 кв.19                                                      ', N'+7 (927) 955-71-59', N'+7 (971) 770-77-75'),
 (7, N'Россия, г. Калининград, Весенняя ул., д. 2 кв.209                                                   ', N'+7 (956) 227-70-72', N'+7 (971) 770-77-76')
GO
INSERT  [Staff_Personal_data] ([id], [Series], [Number], [When_issued], [Issued_by_whom]) VALUES (1, N'4271      ', N'843482    ', N'27.06.2016', N'Россия, г. Челябинск, Лесной пер., д. 1 кв.68                                                       '),
 (2, N'4593      ', N'867838    ', N'16.03.2012', N'Россия, г. Тула, Радужная ул., д. 2 кв.181                                                          '),
 (3, N'4991      ', N'811242    ', N'15.04.2020', N'Россия, г. Жуковский, Парковая ул., д. 3 кв.157                                                     '),
 (4, N'4152      ', N'535764    ', N'21.02.2018', N'Россия, г. Волжский, Солнечная ул., д. 4 кв.10                                                      '),
 (5, N'4348      ', N'757651    ', N'21.05.2013', N'Россия, г. Сочи, Дружная ул., д. 20 кв.167                                                          '),
 (6, N'4581      ', N'537203    ', N'24.06.2014', N'Россия, г. Кемерово, Западная ул., д. 16 кв.19                                                      '),
 (7, N'4269      ', N'919310    ', N'26.06.2020', N'Россия, г. Калининград, Весенняя ул., д. 2 кв.209                                                   ')
GO
