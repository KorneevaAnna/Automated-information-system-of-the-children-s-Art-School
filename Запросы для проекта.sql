-- �������� �������� � ������������ �������������� (���������� ������)
select
  w.Surname,
  w.Name,
  w.Patronymic,
  s.Specialty 
from WORKERS w
join Specialization_of_employees s on s.Sprcialisation_ID = w.Specialization_ID
where s.Level_of_professional_education = '������ �����������'


-- �������� �������� � ����������� �� ��������
select
  w.Surname,
  w.Name,
  w.Patronymic,
  w.Date_of_birth,
  s.Specialty 
from WORKERS w
join Specialization_of_employees s on s.Sprcialisation_ID = w.Specialization_ID
order by w.Date_of_birth


-- ���������� ����� � �������
select
  c.NAME_CLUB,                 -- ������������ ������
  COUNT(*) as COUNT_CHILDREN   -- ���������� ����� � ������ ������
from CLUB c
join LIST_OF_CHILDREN_IN_THE_CLUBS l on l.CLUB_ID = c.CLUB_ID
group by c.NAME_CLUB

