
public class Solution {

    public int CountStudents(int[] students, int[] sandwiches) {
        int n = students.Length;
        Queue<int> q = new Queue<int>();
        foreach(int student in students){
            q.Enqueue(student);
        }

        int res = n;
        foreach(int sandwich in sandwiches){
            int cnt = 0;
            while(cnt < n && q.Peek() != sandwich){
                q.Enqueue(q.Dequeue());
                cnt++;
            }
            if(q.Peek() == sandwich){
                q.Dequeue();
                res--;
            }else{
                break;
            }
        }
        return res;
    }
}