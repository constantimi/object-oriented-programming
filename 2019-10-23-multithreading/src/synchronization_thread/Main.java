package synchronization_thread;

public class Main {
    public static void main(String args[]){
        PrintDemo PD = new PrintDemo();

        Synchronization T1 = new Synchronization("Thread - 1", PD);
        Synchronization T2 = new Synchronization("Thread - 2", PD);

        T1.start();
        T2.start();

        try{
            T1.join();
            T2.join();
        } catch(Exception e){
            System.out.println("Interrupted");
        }
    }
}
