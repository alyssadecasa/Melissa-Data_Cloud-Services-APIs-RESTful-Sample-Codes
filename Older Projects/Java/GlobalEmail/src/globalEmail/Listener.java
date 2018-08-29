/**
 * Listener.java
 * Support class for Main.java
 * Upon the MouseEvent mouseClicked, this program starts the Main.submit() function
 * @author Alyssa House
 */

package globalEmail;

import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

public class Listener implements MouseListener {

	public Listener() {
	}

	@Override
	// Mouse listener for the button
	public void mouseClicked(MouseEvent arg0) {
		Main.submit();
	}

	@Override
	public void mouseEntered(MouseEvent arg0) {

	}

	@Override
	public void mouseExited(MouseEvent arg0) {

	}

	@Override
	public void mousePressed(MouseEvent arg0) {

	}

	@Override
	public void mouseReleased(MouseEvent arg0) {

	}

}
