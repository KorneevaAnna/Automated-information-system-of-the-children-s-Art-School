-- Выбираем учителей с определенной специализацией (используем фильтр)
select
  w.Surname,
  w.Name,
  w.Patronymic,
  s.Specialty 
from WORKERS w
join Specialization_of_employees s on s.Sprcialisation_ID = w.Specialization_ID
where s.Level_of_professional_education = 'Высшее образование'


-- Выбираем учителей с сортировкой по возрасту
select
  w.Surname,
  w.Name,
  w.Patronymic,
  w.Date_of_birth,
  s.Specialty 
from WORKERS w
join Specialization_of_employees s on s.Sprcialisation_ID = w.Specialization_ID
order by w.Date_of_birth


-- Количество детей в кружках
select
  c.NAME_CLUB,                 -- наименование кружка
  COUNT(*) as COUNT_CHILDREN   -- количество детей в данном кружке
from CLUB c
join LIST_OF_CHILDREN_IN_THE_CLUBS l on l.CLUB_ID = c.CLUB_ID
group by c.NAME_CLUB

