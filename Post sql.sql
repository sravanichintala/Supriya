create database DiscussionForum
create table Post(
Post_Id int primary key,
Post_Title varchar(100),
Post_Subtitle varchar(100),
Post_Content varchar(100),
Post_status varchar(50)
)

select * from Post
drop table Post