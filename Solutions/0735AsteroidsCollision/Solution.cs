namespace Solutions._0735AsteroidsCollision;

public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new();
        for(int i=0; i<asteroids.Length; i++){
            if(stack.Count> 0 && asteroids[i]<0 && stack.Peek()>0){
                var asteroid = asteroids[i];
                while(asteroid<0&&stack.Count>0&&stack.Peek()>0){
                    var previous = stack.Pop();
                    if(Math.Abs(previous)>Math.Abs(asteroid)){
                        asteroid = previous;
                    }else if(Math.Abs(previous) == Math.Abs(asteroid)){
                        asteroid = 0;
                        break;
                    }
                }
                if(asteroid!=0) stack.Push(asteroid);
            }else{
                stack.Push(asteroids[i]);
            }
        }
        var result = stack.ToArray();
        Array.Reverse(result);
        return result;
    }
}