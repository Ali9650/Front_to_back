INSERT INTO TeamMembers(Name, Surname, ImgUrl, Position, CreatedAt) VALUES 
('Jhon', 'Doe', '/assets/img/team-01.jpg', 'Business Development', GETDATE()),
('Jane', 'Doe', '/assets/img/team-02.jpg', 'Media Development', GETDATE()),
('Sam', null, '/assets/img/team-03.jpg', 'Developer', GETDATE())
SELECT * FROM TeamMembers

INSERT INTO Works(Title, ImgUrl, Detail, CreatedAt) VALUES 
('UI/UX design', '/assets/img/services-01.jpg', 'Lorem ipsum dolor sit amet, consectetur adipisicing', GETDATE()),
('Social Media', '/assets/img/services-02.jpg', 'Lorem ipsum dolor sit amet, consectetur adipisicing', GETDATE()),
('Marketing', '/assets/img/services-03.jpg', 'Lorem ipsum dolor sit amet, consectetur adipisicing', GETDATE()),
('Graphic', '/assets/img/services-04.jpg', 'Lorem ipsum dolor sit amet, consectetur adipisicing', GETDATE()),
('Digtal MArketing', '/assets/img/services-05.jpg', 'Lorem ipsum dolor sit amet, consectetur adipisicing', GETDATE()),
('Market Research', '/assets/img/services-06.jpg', 'Lorem ipsum dolor sit amet, consectetur adipisicing', GETDATE()),
('Business', '/assets/img/services-07.jpg', 'Lorem ipsum dolor sit amet, consectetur adipisicing', GETDATE()),
('Branding', '/assets/img/services-08.jpg', 'Lorem ipsum dolor sit amet, consectetur adipisicing', GETDATE())

SELECT * FROM Works

INSERT INTO Pricings(Title, Price, UserCapacity, SpaceCapacity, [Type], Servicing, Customize, CreatedAt) VALUES 
('Free Plan', '$0', '5 Users',2, 'Community Forums', 'Email Support',null, GETDATE()),
('Standart Plan', '$120/Year', '25 to 99 Users', 10 , 'Source Files', 'Live Chat',null, GETDATE()),
('Enterprise', '$840/Year', '100 Users or more', 80 , 'Full Access Soursces', 'Live Chat', 'Customizations', GETDATE())


SELECT * FROM Pricings

INSERT INTO Contacts(IconClasses, Title,[Name], Phone, CreatedAt) VALUES 
('display-6 bx bx-news','Media Contact','Mr. John Doe','010-020-0340',GETDATE()),
('bx bx-laptop display-6','Technical Contact','Mr. John Stiles','010-020-0340',GETDATE()),
('bx bx-money display-6','Billing Contact','Mr. Richard Miles','010-020-0340',GETDATE())


SELECT * FROM Contacts

INSERT INTO AboutServices (IconClass, Title, Description,CreatedAt) VALUES
('display-4 bx bxs-bulb text-light', 'Our Vision', 'Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra.', GETDATE()),
('display-4 bx bx-revision text-light', 'Our Mission', 'Eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis.', GETDATE()),
('display-4 bx bxs-select-multiple text-light', 'Our Goal', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor.', GETDATE())
SELECT * FROM AboutServices 