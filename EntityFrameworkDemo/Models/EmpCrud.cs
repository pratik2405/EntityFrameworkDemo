namespace EntityFrameworkDemo.Models
{
    public class EmpCrud
    {
        private readonly ApplicatiobDbContext db;
        public EmpCrud(ApplicatiobDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            //Using LINQ

            var result = (from emp in db.Employees
                         select emp).ToList();
            return result;

            //Using Lambda

            //return db.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            //var result= (from emp in db.Employees
            //            where emp.Eid == id
            //            select emp).SingleOrDefault();
            //return result;

            return db.Employees.Where(x => x.Eid == id).SingleOrDefault();
        }

        public int AddEmployee(Employee emp)
        {
            int result = 0;

            db.Employees.Add(emp);
           
                result = db.SaveChanges();
            

            return result;
        }

        public int UpdateEmployee(Employee emp)
        {
            int result = 0;
            
            var e= db.Employees.Where(x => x.Eid == emp.Eid).SingleOrDefault();

            if(e != null)
            {
                e.Eid = emp.Eid;
                e.Ename = emp.Ename;
                e.Email = emp.Email;
                e.Esal=emp.Esal;

                result=db.SaveChanges();
            }
            return result;
        }

        public int DeleteEmployee(int id)
        {
            int result = 0;

            var e = db.Employees.Where(x => x.Eid == id).SingleOrDefault();

            if (e != null)
            {
               db.Remove(e);

                result = db.SaveChanges();
            }
            return result;
        }
    }
}
