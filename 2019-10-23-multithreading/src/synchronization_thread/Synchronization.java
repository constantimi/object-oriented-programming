package synchronization_thread;

public class Synchronization extends Thread{
    private Thread thread;
    private String threadName;
    PrintDemo PD;

    Synchronization(String name, PrintDemo pd){
        threadName = name;
        PD = pd;
    }

    public void run(){
        PD.printCount();
        System.out.println("Thread " + threadName + " exiting.");
    }

    public void start(){
        System.out.println("Starting " + threadName);
        if(thread == null){
            thread = new Thread(this, threadName);
            thread.start();
        }
    }
}
