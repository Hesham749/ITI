--windowing function
--lead lag first_value last_value Percent_rank

select s.st_id as sid,st_fname as sname,grade,crs_name as Cname into grades
from Student s,Stud_Course sc,Course c
where s.St_Id=sc.St_Id and c.Crs_Id=sc.Crs_Id

select * from grades


SELECT sname,grade,
	   lAG(grade) OVER(ORDER BY grade),
	   LEAD(grade) OVER(ORDER BY grade)
FROM grades



SELECT sname,grade,
	  X= lAG(sname) OVER(ORDER BY grade),
	  Y= LEAD(sname) OVER(ORDER BY grade)
FROM grades


SELECT sname,grade,cname,
	   Prod_prev=lAG(grade) OVER(ORDER BY grade),
	   Prod_Next=LEAD(grade) OVER(ORDER BY grade)
FROM grades

SELECT sname,grade,cname,
	   Prod_prev=lAG(grade) OVER(partition by Cname ORDER BY grade),
	   Prod_Next=LEAD(grade) OVER(partition by Cname ORDER BY grade)
FROM grades


SELECT sname,grade,cname,
	   Prod_prev=lAG(sname) OVER(partition by Cname ORDER BY grade),
	   Prod_Next=LEAD(sname) OVER(partition by Cname ORDER BY grade)
FROM grades


SELECT sname,grade,
	   First=FIRST_VALUE(grade) OVER(ORDER BY grade),
	   last=LAST_VALUE(grade) OVER(ORDER BY grade                                  Rows BETWEEN unbounded preceding AND unbounded following)
FROM grades



SELECT sname,grade,
	   First=FIRST_VALUE(sname) OVER(ORDER BY grade),
	   last=LAST_VALUE(sname) OVER(ORDER BY grade                                  Rows BETWEEN unbounded preceding AND unbounded following)
FROM grades



SELECT sname,grade,cname,
	   First=FIRST_VALUE(grade) OVER(ORDER BY grade),
	   last=LAST_VALUE(grade) OVER(ORDER BY grade                                  Rows BETWEEN unbounded preceding AND unbounded following)
FROM grades

SELECT sname,grade,Cname,
	   FIRST_VALUE(grade) OVER(partition by Cname ORDER BY grade),
	   LAST_VALUE(grade) OVER(partition by Cname ORDER BY grade                   Rows                  BETWEEN unbounded preceding AND unbounded following)
FROM grades


SELECT sname,grade,Cname,
	    FIRST_VALUE(sname) OVER(partition by Cname ORDER BY grade),
	   LAST_VALUE(sname) OVER(partition by Cname ORDER BY grade                   Rows                  BETWEEN unbounded preceding AND unbounded following)
FROM grades


SELECT sname,grade,cname,
	   Prod_prev=lAG(grade) OVER(ORDER BY grade),
	   Prod_Next=LEAD(grade) OVER(ORDER BY grade),
	   First=FIRST_VALUE(grade) OVER(ORDER BY grade),
	   last=LAST_VALUE(grade) OVER(ORDER BY grade                                                 Rows BETWEEN unbounded preceding AND unbounded following)
FROM grades

SELECT sname,grade,Cname,
	   Prod_prev=lAG(grade) OVER(partition by Cname ORDER BY grade),
	   Prod_Next=LEAD(grade) OVER(partition by Cname ORDER BY grade),
	   First=FIRST_VALUE(grade) OVER(partition by Cname ORDER BY grade),
	   last=LAST_VALUE(grade) OVER(partition by Cname ORDER BY grade                             Rows BETWEEN unbounded preceding AND unbounded following)
FROM grades


SELECT sname,grade,Cname,
	   Prod_prev=lAG(sname) OVER(partition by Cname ORDER BY grade),
	   Prod_Next=LEAD(sname) OVER(partition by Cname ORDER BY grade),
	   First=FIRST_VALUE(sname) OVER(partition by Cname ORDER BY grade),
	   last=LAST_VALUE(sname) OVER(partition by Cname ORDER BY grade                             Rows BETWEEN unbounded preceding AND unbounded following)
FROM grades


SELECT sname,grade,Cname,
	   Percent_rank() OVER(partition by Cname ORDER BY grade)  
FROM grades

SELECT sname,grade,Cname,
	   cast(Percent_rank() OVER(partition by Cname ORDER BY grade) as decimal(3,2)) 
FROM grades

SELECT sname,grade,Cname,
	  round(100*cast(Percent_rank() OVER(partition by Cname ORDER BY grade) as decimal(3,2)),0) 
FROM grades

/*
SELECT *,
	  Percent_rank() OVER w as PR
FROM grades
window w as (ORDER BY grade);
*/




