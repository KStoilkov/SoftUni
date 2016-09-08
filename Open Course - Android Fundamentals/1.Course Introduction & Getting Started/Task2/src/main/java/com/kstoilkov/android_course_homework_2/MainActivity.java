package com.kstoilkov.android_course_homework_2;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends Activity implements View.OnClickListener{

    private int lastClickedBtnId;
    private int currentId;
    private String currentText;

    private Button button1;
    private Button button2;
    private Button button3;

    private TextView textView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        lastClickedBtnId = Integer.MIN_VALUE;
        currentText = "";

        button1 = (Button) this.findViewById(R.id.button1);
        button2 = (Button) this.findViewById(R.id.button2);
        button3 = (Button) this.findViewById(R.id.button3);
        textView = (TextView) this.findViewById(R.id.textView);

        button1.setOnClickListener(this);
        button2.setOnClickListener(this);
        button3.setOnClickListener(this);
        textView.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        currentId = view.getId();

        if (currentId == R.id.button1 || currentId == R.id.button2 || currentId == R.id.button3){
            currentText = ((Button) this.findViewById(currentId)).getText().toString();

            if (lastClickedBtnId != currentId){
                // clicked once
                textView.setText(String.valueOf(currentId));
            } else {
                // clicked twice
                textView.setText(currentText);
            }

            lastClickedBtnId = currentId;
        }
        else if (currentId == R.id.textView){
            if (lastClickedBtnId != Integer.MIN_VALUE){
                Intent intent = new Intent(MainActivity.this, ButtonInfoActivity.class);

                intent.putExtra("id", currentId);
                intent.putExtra("text", currentText);

                startActivity(intent);
            }
        }
    }
}
