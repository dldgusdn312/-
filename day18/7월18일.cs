```
--Q1
SELECT DEPTNO,ROUND(AVG(SAL),0)AS AVG_SAL,MAX(SAL)AS MAX_SAL,MIN(SAL)AS MIN_SAL,COUNT(*) AS CNT
FROM EMP GROUP BY DEPTNO ORDER BY DEPTNO;
```
```
--Q2
SELECT JOB,COUNT(*) FROM EMP GROUP BY JOB HAVING COUNT(*)>=3;
```
```
--Q3
SELECT TO_CHAR(HIREDATE,'YYYY')AS HIRE_YEAR,DEPTNO,
COUNT(*)AS CNT FROM EMP GROUP BY TO_CHAR(HIREDATE,'YYYY'),DEPTNO;  
```
```
--Q4
SELECT NVL2(COMM,'O','X')AS EXIST_COMM,COUNT(*)AS CNT FROM EMP GROUP BY COMM;
```
```
--Q5
SELECT DEPTNO,TO_CHAR(HIREDATE,'YYYY')AS HIRE_YEAR,COUNT(*)AS CNT,
MAX(SAL)AS MAX_SAL,SUM(SAL)AS SUM_SAL,
ROUND(AVG(SAL),2)AS AVG_SAL FROM EMP GROUP BY ROLLUP(DEPTNO,HIREDATE);
```
